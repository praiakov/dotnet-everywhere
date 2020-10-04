using System;
using System.Linq;
using VI___MapReduce.Data;
using VI___MapReduce.Queries;

namespace VI___MapReduce
{
    class Program
    {
        static void Main(string[] args)
        {
            using var session = DocumentStoreHolder.Store.OpenSession();
            var results = session
                .Query<ProductsByCategory.Result, ProductsByCategory>()
                //.Include(x => x.Category)
                .ToList();

            foreach (var result in results)
            {
                //var category = session.Load<Category>(result.Category);
                //Console.WriteLine($"{category.Name} has {result.Count} items.");
                Console.WriteLine($"{result.Category} has {result.Count} items.");
            }
        }
    }

    class Category
    {
        public string Name { get; set; }
    }

    class Product
    {
        public string Category { get; set; }
    }
}
