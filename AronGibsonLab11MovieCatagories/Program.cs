using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AronGibsonLab11MovieCatagories
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> Inventory = new List<Movie> {
                new Movie("365 days", "drama"),
                new Movie("The Tomorrow war","scifi"),
                new Movie("Ready Player One", "scifi"),
                new Movie("Space Jam","animated"),
                new Movie("Candy Man","horror"),
                new Movie("Don't Breath 2","horror"),
                new Movie("The Many Saints of Newark","drama"),
                new Movie("Host","horror"),
                new Movie("What Lies Below","horror"),
                new Movie("Luca","animated"),
            };
            MovieStore myStore = new MovieStore(Inventory);

            do {
                myStore.displayMoviesInCatagory();     
            } while (validate.getContinue());
        }
    }
}
