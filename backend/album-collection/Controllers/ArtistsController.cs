using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using album_collection.Models;
using album_collection.Repositories;

namespace album_collection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {

        IRepository<Artist> artistRepo;

        public ArtistsController(IRepository<Artist> artistRepo)
        {
            this.artistRepo = artistRepo;
        }

        //GET: api/Artists
        [HttpGet]
        public IEnumerable<Artist> GetArtists()
        {
            return artistRepo.GetAll();
        }


        [HttpGet("{id}", Name = "GetArtists")]
        public Artist GetArtists(int id)
        {
            return artistRepo.GetById(id);
        }

  
        // PUT: api/Albums/5
        [HttpPut("{id}")]
        public IEnumerable<Artist> PutArtist([FromBody] Artist artist)
        {
            artistRepo.Update(artist);
            return artistRepo.GetAll();
        }

        // POST: api/Artists
        [HttpPost]
        public IEnumerable<Artist> PostArtist([FromBody] Artist value)
        {
            artistRepo.Create(value);
            return artistRepo.GetAll();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IEnumerable<Artist> DeleteArtist(int id)
        {
            var myArtist = artistRepo.GetById(id);
            artistRepo.Delete(myArtist);
            return artistRepo.GetAll();
        }

  

    }
}
