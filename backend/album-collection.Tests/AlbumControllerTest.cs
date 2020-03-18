using album_collection.Models;
using album_collection.Repositories;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using album_collection.Controllers;
using System.Linq;

namespace album_collection.Tests
{
    public class AlbumControllerTest
    {
        AlbumsController underTest;
        IRepository<Album> albumRepo;
        public AlbumControllerTest()
        {
            albumRepo = Substitute.For<IRepository<Album>>();
            underTest = new AlbumsController(albumRepo);

        }

        [Fact]
        public void Get_Returns_3_Albums()
        {
            //Arrange
            var myCollection = new List<Album>()
            {
                new Album(1, "First Album", "columbia records", "img", 1),
                new Album(2, "Second Album", "columbia records", "img", 1),
                new Album(3, "Third Album", "columbia records", "img", 1)

            };
            albumRepo.GetAll().Returns(myCollection);

            //Act
            var result = underTest.GetAlbum();
            var countOfAlbums = result.Count();

            //Assert
            Assert.Equal(3, countOfAlbums);
        }

        // Alternative test for Get() action
        [Fact]
        public void Get_Returns_List_of_Albums()
        {
            // arrange
            var expectedAlbums = new List<Album>()
            {
                new Album(1, "First Album", "columbia records", "img", 1),
                new Album(2, "Second Album", "columbia records", "img", 1),
                new Album(3, "Third Album", "columbia records", "img", 1)

            };

            albumRepo.GetAll().Returns(expectedAlbums);

            // act
            var result = underTest.GetAlbum();

            // assert
            Assert.Equal(expectedAlbums, result.ToList());
        }

        [Fact]
        public void Get_by_id_Returns_Chosen_Album()
        {
            // arrange
            var id = 2;
            var firstAlbum = new Album(1, "First Album", "columbia records", "img", 1);
            var secondAlbum = new Album(2, "Second Album", "columbia records", "img", 1);
            var expectedAlbums = new List<Album>();
            expectedAlbums.Add(firstAlbum);
            expectedAlbums.Add(secondAlbum);

            // We need to mock the Repository's GetById() method
            albumRepo.GetById(id).Returns(secondAlbum);

            // act
            var result = underTest.GetAlbum(id);

            // assert
            Assert.Equal(secondAlbum, result);
        }

        [Fact]
        public void Post_Creates_New_Album()
        {
            // arrange
            var newAlbum = new Album(1, "First Album", "columbia records", "img", 1);
            var albumList = new List<Album>();

            // Use When..Do to substitute for methods that don't return a value, like the Repository method Create()
            // When() allows us to call the method on the substitute and pass an argument
            // Do() allows us to pass a callback function that executes when the method is called
            albumRepo.When(t => t.Create(newAlbum))
                .Do(t => albumList.Add(newAlbum));

            albumRepo.GetAll().Returns(albumList);

            // act
            var result = underTest.PostAlbum(newAlbum);

            // assert
            Assert.Contains(newAlbum, result);
        }


        [Fact]
        public void Delete_Removes_Album()
        {
            // arrange
            var albumId = 1;
            var deletedAlbum = new Album(albumId, "First Album", "columbia records", "img", 1);
            var albumList = new List<Album>()
            {
                deletedAlbum,
                new Album(2,"Second Album", "columbia records", "img", 1)
            };

            // our controller's Delete() action is dependent on the Repository's
            // GetById(), Delete(), and GetAll() actions- they all need to be mocked
            albumRepo.GetById(albumId).Returns(deletedAlbum);
            albumRepo.When(d => d.Delete(deletedAlbum))
                .Do(d => albumList.Remove(deletedAlbum));
            albumRepo.GetAll().Returns(albumList);


            // act
            var result = underTest.DeleteAlbum(albumId);

            // assert
            // Below is an alternative to Assert.DoesNotContain(deletedTodo, result), 
            // which does not work in all cases
            Assert.All(result, item => Assert.Contains("Second Album", item.Title));
        }

        [Fact]
        public void Put_Updates_Album()
        {
            // arrange
            var originalAlbum = new Album(1, "First Album", "columbia records", "img", 1);
            var expectedAlbum = new List<Album>()
            {
                originalAlbum
            };
            var updatedAlbum = new Album(1, "First Album Update", "columbia records", "img", 1);

            // What are the dependencies for the controller's Update action?
            // They are Update() and GetAll()
            // To mock Update() we need to modify our fake list with the Remove() then Add() methods 
            albumRepo.When(t => albumRepo.Update(updatedAlbum))
                .Do(Callback.First(t => expectedAlbum.Remove(originalAlbum))
                .Then(t => expectedAlbum.Add(updatedAlbum)));
            albumRepo.GetAll().Returns(expectedAlbum);

            // act
            var result = underTest.PutAlbum(updatedAlbum);

            // assert
            // Below is an alternative to Assert.Equal(expectedTodos, result.ToList());
            Assert.All(result, item => Assert.Contains("First Album Update", item.Title));
        }

    }
}
