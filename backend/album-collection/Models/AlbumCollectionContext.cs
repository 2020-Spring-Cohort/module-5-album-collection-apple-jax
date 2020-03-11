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
            modelBuilder.Entity<Artist>.HasData(
                new Artist
                {
                    Id = 1,
                    Name = "Pac-Man",
                    // Description = "Yellow fruit-eating monster enjoys cherries but not ghosts",
                    Image = "/img/pacman.jpg"
                });
            base.OnModelCreating(modelBuilder);
        }


    }
}
