using System;
using System.Collections.Generic;
using System.Linq;

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
                Console.WriteLine(student.Key + " " + student.Value);
            }

            Console.ReadLine();
        }
    }
}



//Dictionaries: Make a program similar to GradebookDict, but which takes in 
//students names and ID numbers(as integers) instead of names and grades.
//    In this case, however, the keys should be integers (the IDs) 
//    and the values should be strings (the names). Modify the roster printing code accordingly.