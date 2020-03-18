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
    public class SongsController : ControllerBase
    {

        IRepository<Song> songRepo;

        public SongsController(IRepository<Song> songRepo)
        {
            this.songRepo = songRepo;
        }

        //GET: api/Songs
        [HttpGet]
        public IEnumerable<Song> GetSongs()
        {
            return songRepo.GetAll();
        }

        [HttpGet("{id}", Name = "GetSongs")]
        public Song GetSongs(int id)
        {
            return songRepo.GetById(id);
        }


        // PUT: api/Albums/5
        [HttpPut("{id}")]
        public IEnumerable<Song> PutSong([FromBody] Song song)
        {
            songRepo.Update(song);
            return songRepo.GetAll();
        }


        // POST: api/Artists
        [HttpPost]
        public IEnumerable<Song> PostSong([FromBody] Song value)
        {
            songRepo.Create(value);
            return songRepo.GetAll();
        }


        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IEnumerable<Song> DeleteSong(int id)
        {
            var mySong = songRepo.GetById(id);
            songRepo.Delete(mySong);
            return songRepo.GetAll();
        }
      
    }
}
