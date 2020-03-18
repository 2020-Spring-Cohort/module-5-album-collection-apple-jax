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
        public void Get_Returns_All_Albums()
        {
            //Arrange
            var myCollection = new List<Album>()
            {
                new Album(1, "First Album", "columbia records", "img", 1),
                new Album(2, "Second Album", "columbia records", "img", 1),
                new Album(3, "Third Album", "columbia records", "img", 1)

            };

            underTest.GetAlbum().Returns(myColleciton);

            //Act
            var result = underTest.GetAlbum();
            var countOfAlbums = result.Count();

            //Assert
            Assert.Equal(2, countOfAlbums);
        }

    }
}
