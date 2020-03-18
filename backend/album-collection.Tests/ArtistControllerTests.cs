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
    }
}
