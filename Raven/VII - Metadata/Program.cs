using System;

namespace VII___Metadata
{
    class Program
    {
        static void Main(string[] args)
        {
            using var session = DocumentStoreHolder.Store.OpenSession();
            var product = session.Load<Product>("products/1-A");
            var metadata = session.Advanced.GetMetadataFor(product);

            foreach (var info in metadata)
            {
                Console.WriteLine($"{info.Key}: {info.Value}");
            }
        }
    }

    class Product { }
}
