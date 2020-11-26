using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace fanfic.by.Models
{
    public class Fanfic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public Genre Genre { get; set; }
        public int? GenreId { get; set; }
        public ImageFanfic ImageFanfic { get; set; }
        public int? ImageFanficId { get; set; }
        public string UserId { get; set; }
        public int kolLikes { get; set; }

        [NotMapped]
        public bool IsLiked { get; set; }
    }

        
}
