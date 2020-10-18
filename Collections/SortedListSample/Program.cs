using System;
using System.Collections.Generic;

namespace SortedListSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var sorted = new SortedList<string, int>();

            sorted.Add("coins", 3);
            sorted.Add("books", 41);
            sorted.Add("spoons", 5);

            if (sorted.ContainsKey("books"))
            {
                Console.WriteLine("There are books in the list");
            }

            foreach (var pair in sorted)
            {
                Console.WriteLine(pair);
            }
        }
    }
}
