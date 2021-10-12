using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AronGibsonLab11MovieCatagories
{
    public class validate
    {
        public static bool getContinue() 
        {
            do
            {
                Console.WriteLine("Enter another category? y or n");
                string again = Console.ReadLine().Trim().ToLower();
                if (again=="y")
                {
                    return true;
                }
                else if (again == "n")
                {
                    return false;
                }
                Console.WriteLine("Must select y or n");
            } while (true);        
        
        }

    }
}
