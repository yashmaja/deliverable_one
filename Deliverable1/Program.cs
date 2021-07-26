using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare all variables
            double convertedVal;
            float value;
            string unit;
            string input;
            string prompt = "Please enter unit of measurement (enter a, b, c, or d) : \na. Inches \nb. Feet \nc. Fidget Spinners \nd. memes";
            bool repeat = true;

            while (repeat)
            {
                Console.Write("Please enter value of measurement: ");
                value = float.Parse(Console.ReadLine());

                Console.WriteLine(prompt);
                unit = Console.ReadLine();

                if (unit == "a")
                {
                    convertedVal = value * 3.5;
                    Console.WriteLine("\n" + value + " inches = " + convertedVal + " fidget spinners.");
                }

                else if (unit == "b")
                {
                    convertedVal = value * 5;
                    Console.WriteLine("\n" + value + " feet = " + convertedVal + " memes.");
                }

                else if (unit == "c")
                {
                    convertedVal = value / 3.5;
                    Console.WriteLine("\n" + value + " fidget spinners = " + convertedVal + " inches.");
                }

                else if (unit == "d")
                {
                    convertedVal = value / 5;
                    Console.WriteLine("\n" + value + " memes = " + convertedVal + " feet.");
                }

                else
                {
                    Console.WriteLine("\n Please enter a valid measurement (a, b, c, or d)");
                }

                Console.Write("Would you like to convert another value (y or n)?: ");
                input = Console.ReadLine();

                if (input == "n")
                {
                    Console.WriteLine("Thank you! Bye.");
                    repeat = false;
                }
            }

        }
    }
}
