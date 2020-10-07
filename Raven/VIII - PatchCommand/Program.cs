using static II___DocumentStoreInstanceSingleton.Models.NorthwindModels;

namespace VIII___PatchCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            //using var session = DocumentStoreHolder.Store.OpenSession();
            //session.Advanced.Defer(new PatchCommandData(
            //    id: "orders/816-A",
            //    changeVector: null,
            //    patch: new PatchRequest
            //    {
            //        Script = "this.Lines.push(args.NewLine)",
            //        Values =
            //        {
            //        {
            //            "NewLine", new
            //            {
            //                Product = "products/1-a",
            //                ProductName = "Chai",
            //                PricePerUnit=18M,
            //                Quantity=1,
            //                Discount=0
            //            }
            //        }
            //        }

            //    },
            //    patchIfMissing: null));

            //session.SaveChanges();


            using var session = DocumentStoreHolder.Store.OpenSession();
            session.Advanced.Patch<Order, OrderLine>("orders/816-A",
                x => x.Lines,
                lines => lines.Add(new OrderLine
                {
                    Product = "products/1-a",
                    ProductName = "Chain",
                    PricePerUnit = 18M,
                    Quantity = 1,
                    Discount = 0
                }));

            session.SaveChanges();

        }
    }
}
