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

        IRepository<Artist> albumRepo;

        public ArtistsController(IRepository<Artist> albumRepo)
        {
            this.albumRepo = albumRepo;
        }

        //GET: api/Artists
        [HttpGet]
        public IEnumerable<Artist> GetArtists()
        {
            return albumRepo.GetAll();
        }


        // GET: api/Artists/5
        [HttpGet("{id}")]
        public ActionResult<Artist> GetArtists(int id)
        {
            var myAlbum = albumRepo.GetById(id);
            return myAlbum;
        }

        // PUT: api/Artists/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public IActionResult PutArtist(int id, Artist artist)
        {
            var myAlbum = albumRepo.GetById(id);
            albumRepo.Update(myAlbum);
            return NoContent();
        }


        // POST: api/Artists
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public ActionResult<Artist> PostArtist(Artist artist)
        {
            albumRepo.Create(artist);
            return NoContent();
        }

        // DELETE: api/Artists/5
        [HttpDelete("{id}")]
        public ActionResult<Artist> DeleteArtist(int id)
        {
            var myAlbum = albumRepo.GetById(id);
            albumRepo.Delete(myAlbum);
            return NoContent();
        }

    }
}
