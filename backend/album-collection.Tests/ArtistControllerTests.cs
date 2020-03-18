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
    public class ArtistControllerTests
    {
        ArtistsController underTest;
        IRepository<Artist> artistRepo;
        public ArtistControllerTests()
        {
            artistRepo = Substitute.For<IRepository<Artist>>();
            underTest = new ArtistsController(artistRepo);

        }


        [Fact]
        public void Get_Returns_3_Artists()
        {
            //Arrange
            var myCollection = new List<Artist>()
            {
                new Artist(1,"First Artist",25, "img","columbia records", "atlanta"),
                new Artist(2,"Second Artist",25, "img","columbia records", "atlanta"),
                new Artist(3,"Third Artist",25, "img","columbia records", "atlanta")
            };

            artistRepo.GetAll().Returns(myCollection);

            //Act
            var result = underTest.GetArtists();
            var countOfArtists = result.Count();

            //Assert
            Assert.Equal(3, countOfArtists);
        }

        // Alternative test for Get() action
        [Fact]
        public void Get_Returns_List_of_Artists()
        {
            // arrange
            var expectedArtists = new List<Artist>()
            {
                new Artist(1,"First Artist",25, "img","columbia records", "atlanta"),
                new Artist(2,"Second Artist",25, "img","columbia records", "atlanta"),
                new Artist(3,"Third Artist",25, "img","columbia records", "atlanta")
            };

            artistRepo.GetAll().Returns(expectedArtists);

            // act
            var result = underTest.GetArtists();

            // assert
            Assert.Equal(expectedArtists, result.ToList());
        }

        [Fact]
        public void Get_by_id_Returns_Chosen_Artist()
        {
            // arrange
            var id = 2;
            var firstArtist = new Artist(1, "First Artist", 25, "img", "columbia records", "atlanta");
            var secondArtist = new Artist(2, "Second Artist", 25, "img", "columbia records", "atlanta");
            var expectedArtists = new List<Artist>();
            expectedArtists.Add(firstArtist);
            expectedArtists.Add(secondArtist);

            // We need to mock the Repository's GetById() method
            artistRepo.GetById(id).Returns(secondArtist);

            // act
            var result = underTest.GetArtists(id);

            // assert
            Assert.Equal(secondArtist, result.Value);
        }


        [Fact]
        public void Post_Creates_New_Artist()
        {
            // arrange
            var newArtist = new Artist(1, "First Artist", 25, "img", "columbia records", "atlanta");
            var artistList = new List<Artist>();

            // Use When..Do to substitute for methods that don't return a value, like the Repository method Create()
            // When() allows us to call the method on the substitute and pass an argument
            // Do() allows us to pass a callback function that executes when the method is called
            artistRepo.When(t => t.Create(newArtist))
                .Do(t => artistList.Add(newArtist));

            artistRepo.GetAll().Returns(artistList);

            // act
            var result = underTest.PostArtist(newArtist);

            // assert
            Assert.Contains(newArtist, result);
        }


        [Fact]
        public void Delete_Removes_Artist()
        {
            // arrange
            var artistId = 1;
            var deletedArtist = new Artist(1, "First Artist", 25, "img", "columbia records", "atlanta");
            var artistList = new List<Artist>()
            {
                deletedArtist,
                new Artist(2, "Second Artist", 25, "img", "columbia records", "atlanta")
            };

            // our controller's Delete() action is dependent on the Repository's
            // GetById(), Delete(), and GetAll() actions- they all need to be mocked
            artistRepo.GetById(artistId).Returns(deletedArtist);
            artistRepo.When(d => d.Delete(deletedArtist))
                .Do(d => artistList.Remove(deletedArtist));
            artistRepo.GetAll().Returns(artistList);


            // act
            var result = underTest.DeleteArtist(artistId);

            // assert
            // Below is an alternative to Assert.DoesNotContain(deletedTodo, result), 
            // which does not work in all cases
            Assert.All(result, item => Assert.Contains("Second Artist", item.Name));
        }

        [Fact]
        public void Put_Updates_Artist()
        {
            // arrange
            var originalArtist = new Artist(1, "First Artist", 25, "img", "columbia records", "atlanta");
            var expectedArtist = new List<Artist>()
            {
                originalArtist
            };
            var updatedArtist = new Artist(1, "First Artist Updated", 25, "img", "columbia records", "atlanta");

            // What are the dependencies for the controller's Update action?
            // They are Update() and GetAll()
            // To mock Update() we need to modify our fake list with the Remove() then Add() methods 
            artistRepo.When(t => artistRepo.Update(updatedArtist))
                .Do(Callback.First(t => expectedArtist.Remove(originalArtist))
                .Then(t => expectedArtist.Add(updatedArtist)));
            artistRepo.GetAll().Returns(expectedArtist);

            // act
            var result = underTest.PutArtist(updatedArtist);

            // assert
            // Below is an alternative to Assert.Equal(expectedTodos, result.ToList());
            Assert.All(result, item => Assert.Contains("First Artists Update", item.Name));
        }
    }
}
