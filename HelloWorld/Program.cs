using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            
            Console.WriteLine("Please enter your first name:");
            input = Console.ReadLine();

            Console.WriteLine("Hello " + input + "!");
            Console.ReadLine();
        }
    }
}
