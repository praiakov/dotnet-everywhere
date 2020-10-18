using System;
using System.Collections.Generic;

namespace StackSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var myStack = new Stack<int>();

            myStack.Push(1);
            myStack.Push(4);
            myStack.Push(3);
            myStack.Push(6);
            myStack.Push(4);

            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Peek());

            Console.WriteLine();

            foreach (int item in myStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
