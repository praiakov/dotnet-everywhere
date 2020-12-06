using System;

namespace ValueAndReferencesType
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 10;
            var y = x;
            y++;

            Student s = new Student();

            s.Name = "Bill";

            var s2 = s;

            ChangeName(s2);
                
            Console.WriteLine("Value Type: {0}", x);
            Console.WriteLine("Value Type: {0}", y);
            Console.WriteLine("Refence Type: {0}", s.Name);
        }

        private static void ChangeName(Student s) => s.Name = "Jobs";
        
    }

    internal class Student
    {        
        public string Name { get; internal set; }
    }
}
