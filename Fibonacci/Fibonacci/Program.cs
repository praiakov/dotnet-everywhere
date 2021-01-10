using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {
        public static List<int> Fibonacci(int total)
        {
            List<int> lista = new List<int>();

            int a = 0;
            int b = 1;

            for (int i = 0; i < total; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;

                lista.Add(a);
            }

            return lista;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números para sequência de Fibonacci? ");
            var total = int.Parse(Console.ReadLine());

            var fibList = Fibonacci(total);

            foreach (var item in fibList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
