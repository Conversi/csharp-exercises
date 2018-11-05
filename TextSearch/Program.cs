using System;

namespace TextSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will check to see if a word that you enter is found in opening sentence of Alice in Wonderland.");
            Console.WriteLine("Please enter the word you wish to check:");
            string input = Console.ReadLine();
            string wonderland = "Alice was beginning to get very tired of sitting by her sister on the bank," +
                 " and of having nothing to do: once or twice she had peeped into the book her sister was reading, " +
                 "but it had no pictures or conversations in it, 'and what is the use of a book,' " +
                 "thought Alice 'without pictures or conversation?'";
            bool check = wonderland.Contains(input);
            Console.WriteLine("'{0}' is in the first sentence: {1}",
                               input, check);
            Console.ReadLine();

        }

        private static string TextCheck(string userInput)
        {
            string wonderland = "Alice was beginning to get very tired of sitting by her sister on the bank," +
                        " and of having nothing to do: once or twice she had peeped into the book her sister was reading, " +
                        "but it had no pictures or conversations in it, 'and what is the use of a book,' " +
                        "thought Alice 'without pictures or conversation?'";

            if (wonderland.Contains(userInput))
            {
                return "True";
            }
            else
            {
                return "False";
            }
        }
    }
}
   
