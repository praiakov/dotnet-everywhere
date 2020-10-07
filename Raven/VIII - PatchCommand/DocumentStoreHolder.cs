using Raven.Client.Documents;
using Raven.Client.Documents.Indexes;
using System;
using System.Reflection;

namespace VIII___PatchCommand
{
    public static class DocumentStoreHolder
    {
        public static readonly Lazy<IDocumentStore> LazyStore =
            new Lazy<IDocumentStore>(() =>
            {
                var store = new DocumentStore
                {
                    Urls = new[] { "http://localhost:8080" },
                    Database = "Northwind"
                };

                store.Initialize();

                var asm = Assembly.GetExecutingAssembly();
                IndexCreation.CreateIndexes(asm, store);

                return store;
            });

        public static IDocumentStore Store =>
            LazyStore.Value;
    }
}
