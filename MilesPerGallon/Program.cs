using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {

            double miles;
            double gallons;
            double mpg;
            string input0;
            string input1;

            Console.WriteLine("This program will calculate miles per gallon.");
            Console.WriteLine("Please enter the number of miles traveled:");
            input0 = Console.ReadLine();
            miles = double.Parse(input0);

            Console.WriteLine("Please enter the number of gallons used:");
            input1 = Console.ReadLine();
            gallons = double.Parse(input1);

            mpg = miles / gallons;
            Console.WriteLine("Your MPG is: " + mpg);
            Console.ReadLine();

        }
    }
}
