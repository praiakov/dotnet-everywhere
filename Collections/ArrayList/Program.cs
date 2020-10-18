using System;
using System.Collections;

namespace ArrayListSample
{
    class Empty { }

    class Program
    {
        static void Main(string[] args)
        {
            var data = new ArrayList
            {
                "Visual Basic",
                344,
                55,
                new Empty()
            };
            data.RemoveAt(2);

            foreach (object el in data)
            {
                Console.WriteLine(el);
            }
        }
    }
}
