using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AronGibsonLab11MovieCatagories
{
    class Movie
    {
        public string category { get; set; }
        public string name { get; set; }

        public Movie(string name, string category) {
            this.name = name;
            this.category = category;
        }
    }
}
