using II___DocumentStoreInstanceSingleton.Models;
using II___DocumentStoreInstanceSingleton.Singleton;
using System;
using System.Diagnostics;
using System.Linq;
using static II___DocumentStoreInstanceSingleton.Models.NorthwindModels;
using Product = II___DocumentStoreInstanceSingleton.Models.NorthwindModels.Product;

namespace II___DocumentStoreInstanceSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            using var session = DocumentStoreHolder.Store.OpenSession();
            //var p1 = session.Load<Product>("products/1-A");
            //var p2 = session.Load<Product>("products/1-A");
            //var nah = Debug.Assert(ReferenceEquals(p1, p2));

            var products = session.Load<Product>(new[] {
                "products/1-A",
                "products/2-A",
                "products/3-A"
            });

            //foreach (var item in products)
            //{
            //    Console.WriteLine(item.Key);
            //}

            while (true)
            {
                Console.WriteLine("Please, enter an order # (0 to exit): ");

                int orderNumber;
                if (!int.TryParse(Console.ReadLine(), out orderNumber))
                {
                    Console.WriteLine("Order # is invalid.");
                    continue;
                }

                if (orderNumber == 0) break;

                PrintOrder(orderNumber);
            }

            Console.WriteLine("Goodbye!");

        }

        private static void PrintOrder(int orderNumber)
        {
            using var session = DocumentStoreHolder.Store.OpenSession();

            var order = session
                .Include<Order>(o => o.Company)
                .Include(o => o.Employee)
                .Include(o => o.Lines.Select(l => l.Product))
                .Load($"orders/{orderNumber}-A");

            if (order == null)
            {
                Console.WriteLine($"Order #{orderNumber} not found.");
                return;
            }

            Console.WriteLine($"Order #{orderNumber}");

            var c = session.Load<Company>(order.Company);
            Console.WriteLine($"Company : {c.Id} - {c.Name}");

            var e = session.Load<Employee>(order.Employee);
            Console.WriteLine($"Employee: {e.Id} - {e.LastName}, {e.FirstName}");

            foreach (var orderLine in order.Lines)
            {
                var p = session.Load<Product>(orderLine.Product);
                Console.WriteLine($"   - {orderLine.ProductName}," +
                          $" {orderLine.Quantity} x {p.QuantityPerUnit}");
            }
        }
    }
}
