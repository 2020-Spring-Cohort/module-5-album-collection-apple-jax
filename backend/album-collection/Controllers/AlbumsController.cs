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
       // private readonly Albumcollectioncontext _context;

        //public AlbumsController(Albumcollectioncontext context)
        //{
        //    _context = context;
        //}

        IRepository<Album> albumRepo;

        public AlbumsController(IRepository<Album> albumRepo)
        {
            this.albumRepo = albumRepo;
        }

        //GET: api/Albums
        //[HttpGet]
        // public async Task<ActionResult<IEnumerable<Album>>> GetAlbums()
        // {
        //     //return await _context.Albums.ToListAsync();

        //     return await albumRepo.GetAll();
        // }

        [HttpGet]
        public IEnumerable<Album> GetAlbum()
        {
            return albumRepo.GetAll();
        }

        // GET: api/Albums/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Album>> GetAlbum(int id)
        //{
        //    var album = await _context.Albums.FindAsync(id);

        //    if (album == null)
        //    {
        //        return NotFound();
        //    }

        //    return album;
        //}

        //// PUT: api/Albums/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for
        //// more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutAlbum(int id, Album album)
        //{
        //    if (id != album.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(album).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!AlbumExists(id))
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

        //// POST: api/Albums
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for
        //// more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPost]
        //public async Task<ActionResult<Album>> PostAlbum(Album album)
        //{
        //    _context.Albums.Add(album);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetAlbum", new { id = album.Id }, album);
        //}

        //// DELETE: api/Albums/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Album>> DeleteAlbum(int id)
        //{
        //    var album = await _context.Albums.FindAsync(id);
        //    if (album == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Albums.Remove(album);
        //    await _context.SaveChangesAsync();

        //    return album;
        //}

        //private bool AlbumExists(int id)
        //{
        //    return _context.Albums.Any(e => e.Id == id);
        //}
    }
}
