using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wordList = new List<string>(new string[] {"Write", "a", "static", "method", "to", "print",
                "out", "each", "word", "in", "a", "list", "that", "has", "exactly", "5", "letters" });
            var print5s = Calculate5s(wordList);
            foreach (string item in print5s)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        static List<string> Calculate5s(List<string> wordList)
        {
            List<string> theFives = new List<string>();
            foreach (string item in wordList)
            {
                if (item.Length == 5)
                {
                    theFives.Add(item);
                }
            }
        return theFives;
        }


    }
}

//code snippets from the web:
//List<string> mylist = new List<string>(new string[] { "element1", "element2", "element3" });
