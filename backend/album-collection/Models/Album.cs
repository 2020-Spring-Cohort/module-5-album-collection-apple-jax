using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace album_collection.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string RecordLabel { get; set; }
        public string Comments { get; set; }
        public int Rating { get; set; }

        [JsonIgnore]
        public virtual Artist Artist { get; set; }
        public virtual int ArtistId { get; set; }
        public virtual ICollection<Song> Songs { get; set; }

        public Album()
        {

        }

        public Album(int id, string title, string image, string recordLabel, int artistId, string comments, int rating)
        {
            Id = id;
            Title = title;
            Image = image;
            RecordLabel = recordLabel;
            ArtistId = artistId;
            Comments = comments;
            Rating = rating;
        }

    }
}
