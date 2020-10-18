using System;
using System.Collections.Generic;

namespace QueueSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var msgs = new Queue<string>();

            msgs.Enqueue("Message 1");
            msgs.Enqueue("Message 2");
            msgs.Enqueue("Message 3");
            msgs.Enqueue("Message 4");
            msgs.Enqueue("Message 5");

            Console.WriteLine(msgs.Dequeue());
            Console.WriteLine(msgs.Peek());
            Console.WriteLine(msgs.Peek());

            Console.WriteLine();

            foreach (string msg in msgs)
            {
                Console.WriteLine(msg);
            }
        }
    }
}
