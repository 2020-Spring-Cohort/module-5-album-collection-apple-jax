using Microsoft.EntityFrameworkCore;
using album_collection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace album_collection.Models
{
    public class Albumcollectioncontext : DbContext
    {
       private ModelBuilder modelBuilder;
                
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=ajmusicDB;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
              .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

      
            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             modelBuilder.Entity<Artist>().HasData(
                 new Artist
                {
                    Id = 1,
                    Name = "Usher",
                    Age = 25,
                    Image = "img",
                    RecordLabel = "columbia records",
                    HomeTown = "atlanta",
                });
            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    Id = 1,
                    Title = "Confessions",
                    Duration = "3:12",
                    Link = "song.com",
                    AlbumId = 1,
                });
            modelBuilder.Entity<Album>().HasData(
                new Album
                {
                    Id = 1,
                    Title = "Lock and Key",
                    RecordLabel = "columbia records",
                    Image = "img",
                    ArtistId = 1,
                });
            base.OnModelCreating(modelBuilder);
        }


    }
}
