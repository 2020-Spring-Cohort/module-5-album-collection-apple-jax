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
    public class AlbumsController : ControllerBase
    {

        IRepository<Album> albumRepo;

        public AlbumsController(IRepository<Album> albumRepo)
        {
            this.albumRepo = albumRepo;
        }

        //GET: api/Albums
        [HttpGet]
        public IEnumerable<Album> GetAlbum()
        {
            return albumRepo.GetAll();
        }

        // GET: api/Albums/5
        [HttpGet("{id}")]
        public ActionResult<Album> GetAlbum(int id)
        {
            var myAlbum = albumRepo.GetById(id);
            return myAlbum;
        }

        // PUT: api/Albums/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public IActionResult PutAlbum(int id, Album album)
        {
            if (id != album.Id)
            {
                return BadRequest();
            }

            albumRepo.Update(album);
            return NoContent();
        }


        // POST: api/Albums
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public ActionResult<Album> PostAlbum(Album album)
        {
            albumRepo.Create(album);
            return NoContent();
        }

        // DELETE: api/Albums/5
        [HttpDelete("{id}")]
        public ActionResult<Album> DeleteAlbum(int id)
        {
            var myAlbum = albumRepo.GetById(id);
            albumRepo.Delete(myAlbum);
            return NoContent();
        }

    }
}
