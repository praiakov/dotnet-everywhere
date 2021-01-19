using Facade.Facade;
using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var facade = new CarFacade();
            facade.CreateCompleteCar();

            Console.ReadKey();
        }
    }
}
