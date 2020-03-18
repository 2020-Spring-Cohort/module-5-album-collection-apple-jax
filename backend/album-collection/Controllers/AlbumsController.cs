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

        [HttpGet("{id}", Name = "GetAlbum")]
        public Album GetAlbum(int id)
        {
            return albumRepo.GetById(id);
        }

        // PUT: api/Albums/5
        [HttpPut("{id}")]
        public IEnumerable<Album> PutAlbum([FromBody] Album album)
        {
            albumRepo.Update(album);
            return albumRepo.GetAll();
        }

        // POST: api/Albums
        [HttpPost]
        public IEnumerable<Album> PostAlbum([FromBody] Album value)
        {
            albumRepo.Create(value);
            return albumRepo.GetAll();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IEnumerable<Album> DeleteAlbum(int id)
        {
            var myAlbum = albumRepo.GetById(id);
            albumRepo.Delete(myAlbum);
            return albumRepo.GetAll();
        }

    }
}
