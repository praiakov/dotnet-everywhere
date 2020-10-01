using Raven.Client.Documents;
using System;

namespace II___DocumentStoreInstanceSingleton.Singleton
{
    public static class DocumentStoreHolder
    {
        private static readonly Lazy<IDocumentStore> lazyStore = new Lazy<IDocumentStore>(() =>
        {
            var store = new DocumentStore
            {
                Urls = new[] { "http://localhost:8080" },
                Database = "Northwind"
            };

            return store.Initialize();

        });

        public static IDocumentStore Store =>
        lazyStore.Value;
    }
}
