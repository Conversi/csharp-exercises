using System;
using System.Collections.Generic;
using System.Text;

namespace Class2PracticeProblems
{
    public class ExerciseOne
    {
        public static void Run()
        {
            List<int> integers = SetupIntegersList();
            int sum = GetSumOfEvenIntegers(integers);
            Console.WriteLine(sum);
        }


        private static List<int> GetSumOfEvenIntegers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();
            foreach (int integer in integers)

                if (integer % 2 == 0)
                {
                    evenNumbers.Add(integer);
                }
            int sum = evenNumbers.Sum();
            List<int> sumList = new List<int>();


            private static int SetupIntegers()
        {
            List<int> integers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                integers.Add(i);
            }
        }
    }
}
