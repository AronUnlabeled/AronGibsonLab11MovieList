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
                new Movie("Candy Man", "horror"),
                new Movie("Black Widow","action"),
                new Movie("Venom","action"),
                new Movie("Space Jam","comedy"),
                new Movie("Vacation Friends","comedy"),
                new Movie("Don't Breath 2","horror"),
                new Movie("The Paper Tigers","action"),
                new Movie("Host","horror"),
                new Movie("What Lies Below","horror"),
                new Movie("Tenet","action"),
            };



            MovieStore myStore = new MovieStore(Inventory);

            do {
                myStore.displayMoviesInCatagory();     
            } while (validate.getContinue());

        }
    }
}
