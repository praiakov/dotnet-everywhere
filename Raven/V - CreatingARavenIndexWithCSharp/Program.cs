using Raven.Client.Documents;
using Raven.Client.Documents.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using V___CreatingARavenIndexWithCSharp.Data;
using V___CreatingARavenIndexWithCSharp.Indexes;

namespace V___CreatingARavenIndexWithCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // store index
            //var store = DocumentStoreHolder.Store;
            //new Employes_ByFirstAndLastName().Execute(store);

            //querying
            //using var session = DocumentStoreHolder.Store.OpenSession();
            //var results = session
            //    .Query<Employee, Employes_ByFirstAndLastName>()
            //    .Where(x => x.FirstName == "Robert")
            //    .ToList();

            //foreach (var employee in results)
            //{
            //    Console.WriteLine($"{employee.LastName}, {employee.FirstName}");
            //}

            Console.Title = "Multi-map sample";
            using var session = DocumentStoreHolder.Store.OpenSession();
            while (true)
            {
                Console.Write("\nSearch terms: ");
                var searchTerms = Console.ReadLine();

                foreach (var result in Search(session, searchTerms))
                {
                    Console.WriteLine($"{result.SourceId}\t{result.Type}\t{result.Name}");
                }
            }

        }

        public static IEnumerable<People_Search.Result> Search(
            IDocumentSession session,
            string searchTerms
        )
        {
            var results = session.Query<People_Search.Result, People_Search>()
                .Search(
                    r => r.Name,
                    searchTerms
                )
                .ProjectInto<People_Search.Result>()
                .ToList();

            return results;
        }
    }
}
