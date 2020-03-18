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


        // GET: api/Artists/5
        [HttpGet("{id}")]
        public ActionResult<Artist> GetArtists(int id)
        {
            var myArtist = artistRepo.GetById(id);
            return myArtist;
        }

        // PUT: api/Artists/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public IActionResult PutArtist(int id, Artist artist)
        {
            if (id != artist.Id)
            {
                return BadRequest();
            }

            artistRepo.Update(artist);
            return NoContent();
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
