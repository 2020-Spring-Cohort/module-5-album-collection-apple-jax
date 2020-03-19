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
    public class SongControllerTest
    {
        public class SongControllerTests
        {
            SongsController underTest;
            IRepository<Song> songRepo;

            public SongControllerTests()
            {
                songRepo = Substitute.For<IRepository<Song>>();
                underTest = new SongsController(songRepo);

            }

            [Fact]
            public void Get_Returns_3_Songs()
            {
                //Arrange
                var myCollection = new List<Song>()
            {
                new Song(1,"First Song","3:12","song.com", 1),
                new Song(2,"Second Song","3:12","song.com", 1),
                new Song(3,"Third Song","3:12","song.com", 1)
            };

                songRepo.GetAll().Returns(myCollection);

                //Act
                var result = underTest.GetSongs();
                var countOfSongs = result.Count();

                //Assert
                Assert.Equal(3, countOfSongs);
            }

            // Alternative test for Get() action
            [Fact]
            public void Get_Returns_List_of_Songs()
            {
                // arrange
                var expectedSongs = new List<Song>()
            {
                new Song(1,"First Song","3:12","song.com", 1),
                new Song(2,"Second Song","3:12","song.com", 1),
                new Song(3,"Third Song","3:12","song.com", 1)
            };

                songRepo.GetAll().Returns(expectedSongs);

                // act
                var result = underTest.GetSongs();

                // assert
                Assert.Equal(expectedSongs, result.ToList());
            }

            [Fact]
            public void Get_by_id_Returns_Chosen_Song()
            {
                // arrange
                var id = 2;
                var firstSong = new Song(1, "First Song", "3:12", "song.com", 1);
                var secondSong = new Song(2, "Second Song", "3:12", "song.com", 1);
                var expectedSongs = new List<Song>();
                expectedSongs.Add(firstSong);
                expectedSongs.Add(secondSong);

                // We need to mock the Repository's GetById() method
                songRepo.GetById(id).Returns(secondSong);

                // act
                var result = underTest.GetSongs(id);

                // assert
                Assert.Equal(secondSong, result);
            }

            [Fact]
            public void Post_Creates_New_Song()
            {
                // arrange
                var newSong = new Song(1, "First Song", "3:12", "song.com", 1);
                var songList = new List<Song>();

                // Use When..Do to substitute for methods that don't return a value, like the Repository method Create()
                // When() allows us to call the method on the substitute and pass an argument
                // Do() allows us to pass a callback function that executes when the method is called
                songRepo.When(t => t.Create(newSong))
                    .Do(t => songList.Add(newSong));

                songRepo.GetAll().Returns(songList);

                // act
                var result = underTest.PostSong(newSong);

                // assert
                Assert.Contains(newSong, result);
            }

            [Fact]
            public void Delete_Removes_Song()
            {
                // arrange
                var songId = 1;
                var deletedSong = new Song(1, "First Song", "3:12", "song.com", 1);
                var songList = new List<Song>()
            {
                deletedSong,
                new Song(2, "Second Song", "3:12", "song.com", 1)
            };

                // our controller's Delete() action is dependent on the Repository's
                // GetById(), Delete(), and GetAll() actions- they all need to be mocked
                songRepo.GetById(songId).Returns(deletedSong);
                songRepo.When(d => d.Delete(deletedSong))
                    .Do(d => songList.Remove(deletedSong));
                songRepo.GetAll().Returns(songList);


                // act
                var result = underTest.DeleteSong(songId);

                // assert
                // Below is an alternative to Assert.DoesNotContain(deletedTodo, result), 
                // which does not work in all cases
                Assert.All(result, item => Assert.Contains("Second Song", item.Title));
            }

            [Fact]
            public void Put_Updates_Song()
            {
                // arrange
                var originalSong = new Song(1, "First Song", "3:12", "song.com", 1);
                var expectedSong = new List<Song>()
            {
                originalSong
            };
                var updatedSong = new Song(1, "First Song Updated", "3:12", "song.com", 1);

                // What are the dependencies for the controller's Update action?
                // They are Update() and GetAll()
                // To mock Update() we need to modify our fake list with the Remove() then Add() methods 
                songRepo.When(t => songRepo.Update(updatedSong))
                    .Do(Callback.First(t => expectedSong.Remove(originalSong))
                    .Then(t => expectedSong.Add(updatedSong)));
                songRepo.GetAll().Returns(expectedSong);

                // act
                var result = underTest.PutSong(updatedSong);

                // assert
                // Below is an alternative to Assert.Equal(expectedTodos, result.ToList());
                Assert.All(result, item => Assert.Contains("First Song Updated", item.Title));
            }


        }

    }
}
