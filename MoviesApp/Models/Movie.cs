using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Models
{
    public class Movie
    {
    
        public string name { get; set; }
        public string genre { get; set; }
        public Guid id { get; set; }
    }
}
