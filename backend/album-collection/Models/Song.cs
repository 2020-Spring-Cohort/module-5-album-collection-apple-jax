using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace album_collection.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public string Link { get; set; }

        [JsonIgnore]
        public virtual Album Album { get; set; }
        public virtual int AlbumId { get; set; }
    }
}
