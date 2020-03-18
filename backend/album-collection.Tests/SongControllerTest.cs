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



        }
           
    }
}
