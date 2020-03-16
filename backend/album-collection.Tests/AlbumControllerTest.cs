using album_collection.Models;
using album_collection.Repositories;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using album_collection.Controllers;
using NSubstitute;

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



    }
}
