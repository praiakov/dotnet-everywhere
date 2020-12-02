using System;

namespace ExtensionMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 9;

            bool result = i.IsPair();

            Console.WriteLine(result);
        }
    }

    public static class PairExtensions
    {
        public static bool IsPair(this int value)
        {

            return value % 2 == 0 ? true : false;

        }
    }
}
