using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double area;
            string input;
            
            Console.WriteLine("This program will calculate the area of a circle.");
            Console.WriteLine("Please enter the radius of the circle:");
            input = Console.ReadLine();
            radius = double.Parse(input);

            area = Math.PI * (Math.Pow(radius, 2));
            Console.WriteLine("The area of your circle is: " + area);
            Console.ReadLine();
        }
    }
}
// a = pi * r * r



//private static string getradiuinput()

//{
    //Console.WritLine("Enter radius:");
    //while (!ValidateInput(Console.ReadLine())
    //{
        //Console.WriteLine("Please enter an integer:");
        //Console.WriteLine("Enter radius:");
    //}
//}
//return radius

//private static bool ValidateInput(string input, out int output);
//{
    //return int.TryParse(input, out Outputter);
//}