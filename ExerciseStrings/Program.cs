using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseDictionaries
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish)");
            do
            {
                Console.Write("name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    // Get the student's grade
                    Console.WriteLine("ID: ");
                    int newId = int.Parse(Console.ReadLine());

                    students.Add(newId, newStudent);
                }
            }
            while (newStudent != "");

            // Print class roster
            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<int, string> student in students)
            {
                StringBuilder studentList = new StringBuilder();
                int intKey = student.Key;
                string stringKey = intKey.ToString();
                studentList.Append(stringKey).Append(" ").Append(student.Value);

                Console.WriteLine(studentList);
            }

            Console.ReadLine();
        }
    }
}


//StringBuilder sb = new StringBuilder("Hello World!");
//Console.WriteLine(sb.ToString());
//student.Key + " " + student.Value

//Strings: In one of the Gradebook programs(it doesn't matter which), modify the code that prints
//    out the class roster near the end of the program to use the StringBuilder class.