using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers =  new List<int>();
            for (int i = 0; i <10; i++)
            {
                numbers.Add(i);
            }
            List<int> sumList = CalculateEvens(numbers);
            foreach (int item in sumList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        private static List<int> CalculateEvens(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();
            foreach (int number in numbers)

                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            int sum = evenNumbers.Sum();
            List<int> sumList = new List<int>();
            sumList.Add(sum);
            return sumList;    
        }
    }
}




//List<string> students = new List<string>();
//for (int i = 0; i<students.Count; i++)
//if (min % 2 != 0)
//int sum1 = array1.Sum();






//static int SumEvenNumbers(params int[] values)
//{
//    int result = 0;

//    for (int i = 0; i < values.Length; i++)
//    {
//        int number = values[i];
//        if (IsEven(number))
//        {
//           result += number;   
//        }
//    }
//    return result;
//}

//static int IsEvenNumber(params int[] values)
//{
//    return 0;
//}
//static bool IsEven(int i)
//{
//    return i % 2 == 0;
//}