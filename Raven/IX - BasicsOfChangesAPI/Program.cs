using System;
using VIII___PatchCommand;

namespace IX___BasicsOfChangesAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var subscription = DocumentStoreHolder.Store
                .Changes()
                .ForAllDocuments()
                .Subscribe(change =>
                    Console.WriteLine($"{change.Type} on document {change.Id}"));

            Console.WriteLine("Press any key to exit...");

            subscription.Dispose();
        }
    }
}
