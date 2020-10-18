using System;
using System.Collections.Generic;

namespace LinkedListSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new LinkedList<int>();

            nums.AddLast(23);
            nums.AddLast(34);
            nums.AddLast(33);
            nums.AddLast(11);
            nums.AddLast(6);
            nums.AddFirst(9);
            nums.AddFirst(7);

            LinkedListNode<int> node = nums.Find(6);
            nums.AddAfter(node, 5);

            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}
