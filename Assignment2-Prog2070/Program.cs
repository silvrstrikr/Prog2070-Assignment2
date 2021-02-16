using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Prog2070
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDimension("Length"));
        }

        static int GetDimension(string dimensionName)
        {
            bool invalid = true;
            string input;
            int dimension;
            do
            {
                Console.WriteLine("Please enter Rectangle " + dimensionName + " : Must be > 0");
                input = Console.ReadLine();
                if (!int.TryParse(input, out dimension))
                {
                    Console.WriteLine("You Must enter a Numeric value");
                }
                else if (dimension < 1)
                {
                    Console.WriteLine("Your number must be greater than 0");
                }
                else
                {
                    invalid = false;
                }

            } while (invalid);

            
            return dimension;
        }
    }
}
