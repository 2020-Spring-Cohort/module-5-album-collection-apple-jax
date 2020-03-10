using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace album_collection.Models
{
    public class Albumcollectioncontext : DbContext
    {
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
    }
}
