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


        // GET: api/Songs/5
        [HttpGet("{id}")]
        public ActionResult<Song> GetSongs(int id)
        {
            var mySong = songRepo.GetById(id);
            return mySong;
        }

        // PUT: api/Songs/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public IActionResult PutSong(int id, Song Song)
        {
            var mySong = songRepo.GetById(id);
            songRepo.Update(mySong);
            return NoContent();
        }


        // POST: api/Songs
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public ActionResult<Song> PostSong(Song Song)
        {
            songRepo.Create(Song);
            return NoContent();
        }

        // DELETE: api/Songs/5
        [HttpDelete("{id}")]
        public ActionResult<Song> DeleteSong(int id)
        {
            var mySong = songRepo.GetById(id);
            songRepo.Delete(mySong);
            return NoContent();
        }

   
        //// PUT: api/Songs/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for
        //// more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutSong(int id, Song song)
        //{
        //    if (id != song.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(song).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!SongExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

      
    }
}
