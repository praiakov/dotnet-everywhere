using I___RavenClient.Models;
using Raven.Client.Documents;
using System;

namespace I___RavenClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var documentStore = new DocumentStore
            {
                Urls = new[] { "http://localhost:8080" },
                Database = "Northwind"
            };

            documentStore.Initialize();

            using var session = documentStore.OpenSession();
            var p = session.Load<Product>("products/1-A");
            Console.WriteLine(string.Format("Name: {0}", p.Name));
        }
    }
}
