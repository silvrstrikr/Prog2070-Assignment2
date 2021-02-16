/*
 * Alan Beals
 * Assignment 2
 * Prog 2070 - Quality Assurance
 * 8658171
 * 2021-02-16
 *
 */

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
            Console.WriteLine("Welcome to Your Rectangle Program\n\n");

            Rectangle userRectangle = new Rectangle(GetDimension("Width"), GetDimension("Length"));
            bool leave = false;
            string input;

            while (!leave)
            {
                Console.WriteLine("Main Menu:");
                Console.WriteLine("Enter the number of the action you wish to take");
                Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2. Change Rectangle Length");
                Console.WriteLine("3. Get Rectangle Width");
                Console.WriteLine("4. Change Rectangle Width");
                Console.WriteLine("5. Get Rectangle Perimeter");
                Console.WriteLine("6. Get Rectangle Area");
                Console.WriteLine("7. Exit");

                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Your Length is: " + userRectangle.GetLength() + "\n");
                        break;
                    case "2":
                        Console.WriteLine("Your current length is: " + userRectangle.GetLength());
                        userRectangle.SetLength(GetDimension("Length"));
                        Console.WriteLine("Your new length is " + userRectangle.GetLength() + "\n");
                        break;
                    case "3":
                        Console.WriteLine("Your Width is: " + userRectangle.GetWidth() + "\n");
                        break;
                    case "4":
                        Console.WriteLine("Your current width is: " + userRectangle.GetWidth());
                        userRectangle.SetWidth(GetDimension("Width"));
                        Console.WriteLine("Your new length is " + userRectangle.GetWidth() + "\n");
                        break;
                    case "5":
                        Console.WriteLine("Your Perimeter is: " + userRectangle.GetPerimeter() + "\n");
                        break;
                    case "6":
                        Console.WriteLine("Your Area is: " + userRectangle.GetArea() + "\n");
                        break;
                    case "7":
                        Console.WriteLine("GoodBye");
                        leave = true;
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;

                }
            }

        }

        static int GetDimension(string dimensionName)
        {
            bool invalid = true;
            string input;
            int dimension;
            do
            {
                Console.WriteLine("Please enter Rectangle " + dimensionName + ". Must be > 0");
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
