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
                     Image = "artist1.jpg",
                     RecordLabel = "columbia records",
                     HomeTown = "atlanta",
                 },
                new Artist
                {
                    Id = 2,
                    Name = "Artist A",
                    Age = 25,
                    Image = "artist2.jpg",
                    RecordLabel = "columbia records",
                    HomeTown = "chicago",
                },
                new Artist
                {
                    Id = 3,
                    Name = "Artist B",
                    Age = 25,
                    Image = "artist3.jpg",
                    RecordLabel = "columbia records",
                    HomeTown = "cleveland",
                });

            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    Id = 1,
                    Title = "Confessions",
                    Duration = "3:12",
                    Link = "https://www.youtube.com/watch?v=m6urbZyHgO4",
                    AlbumId = 1,
                },
                new Song
                {
                    Id = 2,
                    Title = "Confessions Part 2",
                    Duration = "3:12",
                    Link = "https://www.youtube.com/watch?v=m6urbZyHgO4",
                    AlbumId = 1,
                },
                new Song
                {
                    Id = 3,
                    Title = "Confessions Part 3",
                    Duration = "3:12",
                    Link = "https://www.youtube.com/watch?v=m6urbZyHgO4",
                    AlbumId = 1,
                },
                new Song
                {
                    Id = 4,
                    Title = "Song A-1",
                    Duration = "3:12",
                    Link = "https://www.youtube.com/watch?v=m6urbZyHgO4",
                    AlbumId = 2,
                },
                new Song
                {
                    Id = 5,
                    Title = "Song A-2",
                    Duration = "3:12",
                    Link = "https://www.youtube.com/watch?v=m6urbZyHgO4",
                    AlbumId = 2,
                },
                new Song
                {
                    Id = 6,
                    Title = "Song A-3",
                    Duration = "3:12",
                    Link = "https://www.youtube.com/watch?v=m6urbZyHgO4",
                    AlbumId = 2,
                },
                new Song
                {
                    Id = 7,
                    Title = "Song B-1",
                    Duration = "3:12",
                    Link = "https://www.youtube.com/watch?v=m6urbZyHgO4",
                    AlbumId = 3,
                },
                new Song
                {
                    Id = 8,
                    Title = "Song B-2",
                    Duration = "3:12",
                    Link = "https://www.youtube.com/watch?v=m6urbZyHgO4",
                    AlbumId = 3,
                },
                 new Song
                 {
                     Id = 9,
                     Title = "Song B-3",
                     Duration = "3:12",
                     Link = "https://www.youtube.com/watch?v=m6urbZyHgO4",
                     AlbumId = 3,
                 }

                );
            modelBuilder.Entity<Album>().HasData(
                new Album
                {
                    Id = 1,
                    Title = "Lock and Key",
                    RecordLabel = "columbia records",
                    Image = "album1.jpg",
                    ArtistId = 1,
                    Comments = "Here is a great comment",
                    Rating = 5,

                },
                new Album
                {
                    Id = 2,
                    Title = "Artist A Album",
                    RecordLabel = "columbia records",
                    Image = "album2.jpg",
                    ArtistId = 2,
                    Comments = "Here is a great comment",
                    Rating = 5,
                },
                new Album
                {
                    Id = 3,
                    Title = "Artist B Album",
                    RecordLabel = "columbia records",
                    Image = "album3.jpg",
                    ArtistId = 3,
                    Comments = "Here is a great comment",
                    Rating = 5,
                });
            base.OnModelCreating(modelBuilder);
        }


    }
}
