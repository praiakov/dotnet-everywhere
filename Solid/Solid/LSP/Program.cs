using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Dog();
            cat.GetName();
        }
    }

    public class Cat
    {
        public virtual string GetName()
        {
            return nameof(Cat);
        }

        public void Move()
        {
            /// Implementation
        }

        public void Eat()
        {
            /// Implementation
        }
    }

    public class Dog : Cat
    {
        public override string GetName()
        {
            return nameof(Dog);
        }
    }

}
