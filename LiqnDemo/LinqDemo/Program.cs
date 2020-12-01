using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cidades = new List<string>();
            cidades.Add("São Paulo");
            cidades.Add("Curitiba");
            cidades.Add("São José");
            cidades.Add("Campinas");
            cidades.Add("Rio de Janeiro");

            BuscarListaComLinqLambda(cidades, "São").ForEach(x => Console.WriteLine(x));

            var listaFiltrada = BuscarListaComLinqLambda(cidades, "São");

            Console.WriteLine(listaFiltrada.Where(x => x.Length > 8).Select(x => x).FirstOrDefault());

        }

        public static List<string> BuscarListaComLinq(List<string> lista, string termo)
        {
            return (from item in lista where item.Contains(termo) select item).ToList();
        }

        public static List<string> BuscarListaComLinqLambda(List<string> lista, string termo)
        {
            return lista.Where(x => x.Contains(termo)).ToList();
        }
    }
}
