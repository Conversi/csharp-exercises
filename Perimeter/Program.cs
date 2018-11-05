using System;

namespace Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            // hello there
            Console.WriteLine("Enter length:");
           string lengthInput =  Console.ReadLine();
            Console.WriteLine("Enter width:");
            string widthInput = Console.ReadLine();
            int perimeter = CalculatePerimiter(lengthInput, widthInput);
            Console.WriteLine(perimeter);
            Console.ReadLine();

        }

        private static int CalculatePerimiter(string lengthInput, string widthInput)
        {
            int perimeter =0;
            bool checkIt = int.TryParse(lengthInput, out int length);
            bool checkToo = int.TryParse(widthInput, out int width);
            perimeter = 2 * length + 2 * width;
            return perimeter;
        }
    }
}
