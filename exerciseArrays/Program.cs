using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exerciseArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6] { 1, 1, 2, 3, 5, 8 };
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}

// Notes and code snippets:
//Create and initialize in a single line an array with the
//    following values: 1, 1, 2, 3, 5, 8. Then loop through the array and print out each value.
//int maxStudents = 30;

//string[] students = new string[maxStudents];
