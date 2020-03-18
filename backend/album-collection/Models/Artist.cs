using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace album_collection.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Image { get; set; }
        public string RecordLabel { get; set; }
        public string HomeTown { get; set; }

        public virtual ICollection<Album> Albums { get; set; }

        public Artist()
        {

        }

        public Artist(int id, string name, int age, string image, string recordLabel, string homeTown)
        {
            Id = id;
            Name = name;
            Age = age;
            Image = image;
            RecordLabel = recordLabel;
            HomeTown = homeTown;
        }
    }

   
}
