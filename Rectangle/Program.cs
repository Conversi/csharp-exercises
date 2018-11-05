using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            double area;
            string input0;
            string input1;

            Console.WriteLine("This program will calculate the area of a rectangle.");
            Console.WriteLine("Please enter the length of the long sides:");
            input0 = Console.ReadLine();
            length = double.Parse(input0);

            Console.WriteLine("Please enter the length of the short sides:");
            input1 = Console.ReadLine();
            width = double.Parse(input1);

            area = length * width;
            Console.WriteLine("The area of your rectangle is: " + area);
            Console.ReadLine();
        }
    }
}
