using System;

namespace Record
{
    class Program
    {
        static void Main(string[] args)
        {
            var venda = new Vendas("Loja SP", 10.000m);
            var venda2 = new Vendas("Loja SP", 10.000m);
            var venda3 = new Vendas("Loja RJ", 5.000m);

            if(venda == venda2)
                Console.WriteLine("Venda 1 é igual a venda 2");

            if (venda == venda2)
                Console.WriteLine("Venda 1 não é igual a venda 3");
        }

        public record Vendas(string nomeLoja, decimal totalVendido);
    }
}
