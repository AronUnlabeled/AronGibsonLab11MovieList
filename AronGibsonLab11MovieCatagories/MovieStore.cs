using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AronGibsonLab11MovieCatagories
{
    class MovieStore
    {
        List<Movie> movieList { get; set; }

        public MovieStore(List<Movie> movieList) 
        {
            this.movieList = movieList;
        }

        public void displayMoviesInCatagory() 
        {
            do {
                Console.WriteLine("Enter a category. horror/scifi/animated/drama");
                string category = Console.ReadLine().Trim().ToLower();
                if (category=="")
                    Console.WriteLine("You can not enter a blank");
                else if (movieList.Any(movie => movie.category.ToLower() == category))
                {
                    foreach (Movie movie in movieList)
                        if (movie.category == category)
                            Console.WriteLine(movie.name);
                    break;
                }
                Console.WriteLine("not a valid category");
            } while (true);
        }        
    }
}
