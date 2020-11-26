using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fanfic.by.Models
{
    public class Like
    {
        public int Id { get; set; }
        public string IdUser { get; set; }
        public int IdFanfic { get; set; }
    }
}
