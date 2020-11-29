using Raven.Client.Documents.Operations;
using VIII___PatchCommand;

namespace BatchOperationsWithRavenDB
{
    class Program
    {
        static void Main(string[] args)
        {
            var operation = DocumentStoreHolder.Store
            .Operations
            .Send(new PatchByQueryOperation(@"from Products as p
                                    where p.Discontinued = false
                                    update
                                    {
                                        p.PricePerUnit = p.PricePerUnit * 1.1
                                    }"));
            operation.WaitForCompletion();
        }
    }
}
