using Raven.Client.Documents.Indexes;
using System.Linq;

namespace VI___MapReduce.Queries
{
    class ProductsByCategory : AbstractIndexCreationTask<Product, ProductsByCategory.Result>
    {
        public class Result
        {
            public string Category { get; set; }
            public int Count { get; set; }
        }

        public ProductsByCategory()
        {
            Map = products =>
            from product in products
            let categoryName = LoadDocument<Category>(product.Category).Name //LoadDocument
            select new
            {
                Category = product.Category,
                Count = 1
            };

            Reduce = results =>
                from result in results
                group result by result.Category into g
                select new
                {
                    Category = g.Key,
                    Count = g.Sum(x => x.Count)
                };
        }
    }
}
