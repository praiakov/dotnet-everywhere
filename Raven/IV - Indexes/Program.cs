using Raven.Client.Documents;
using System;
using System.Linq;

namespace IV___Indexes
{
    class Program
    {
        static void Main(string[] args)
        {
            using var session = DocumentStoreHolder.Store.OpenSession();
            var ordersIds = 
                from order in session.Query<Order>()
                where "companies/1-A" == order.Company
                orderby order.OrderedAt
                select order.Id
                ;

            foreach (var id in ordersIds)
            {
                Console.WriteLine(id);
            }
        }

        public static class DocumentStoreHolder
        {
            private static readonly Lazy<IDocumentStore> LazyStore =
                new Lazy<IDocumentStore>(() =>
                {
                    var store = new DocumentStore
                    {
                        Urls = new[] { "http://localhost:8080" },
                        Database = "Northwind"
                    };

                    return store.Initialize();
                });

            public static IDocumentStore Store =>
                LazyStore.Value;
        }

        public class Order
        {
            public string Id { get; set; }
            public string Company { get; set; }
            public DateTimeOffset OrderedAt { get; set; }
        }
    }
}
