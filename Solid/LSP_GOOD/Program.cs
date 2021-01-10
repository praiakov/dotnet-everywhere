using System;
using System.Collections.Generic;

namespace LSP_GOOD
{
    public abstract class Animal
    {
        public abstract string GetName();

        public virtual void Move()
        {
            /// Implementation
        }

        public void Eat()
        {
            /// Implementation
        }
    }

    public sealed class Cat : Animal
    {
        public override string GetName()
        {
            return nameof(Cat);
        }
    }

    public sealed class Dog : Animal
    {
        public override string GetName()
        {
            return nameof(Dog);
        }

        public override void Move()
        {
            /// Implementation
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>
        {
            new Cat(),
            new Dog()
        };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetName());
                animal.Move();
                animal.Eat();
            }
        }
    }
}
