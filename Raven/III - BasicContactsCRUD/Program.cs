using System;
using BasicContactsCRUD.Repository;

namespace BasicContactsCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Run();
        }

        private void Run()
        {
            while (true)
            {
                Console.WriteLine("Please, press:");
                Console.WriteLine("C - Create");
                Console.WriteLine("R - Retrieve");
                Console.WriteLine("U - Update");
                Console.WriteLine("D - Delete");
                Console.WriteLine("Q - Query all contacts (limit to 128 items)");

                var input = Console.ReadKey();

                Console.WriteLine("\n------------");

                switch (input.Key)
                {
                    case ConsoleKey.C:
                        ContactRepository.CreateContact();
                        break;
                    case ConsoleKey.R:
                        ContactRepository.RetrieveContact();
                        break;
                    case ConsoleKey.U:
                        ContactRepository.UpdateContact();
                        break;
                    case ConsoleKey.D:
                        ContactRepository.DeleteContact();
                        break;
                    case ConsoleKey.Q:
                        ContactRepository.QueryAllContacts();
                        break;
                    default:
                        return;
                }

                Console.WriteLine("------------");
            }
        }
    }
}
