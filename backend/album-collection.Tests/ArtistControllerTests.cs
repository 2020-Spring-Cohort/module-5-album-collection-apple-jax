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

    }
}
