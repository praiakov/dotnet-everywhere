using System;

namespace Delegates
{
    public delegate void ConjuntodeMetodos(string nome);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seu nome: ");
            var nome = Console.ReadLine();

            var cjtMetodos = new ConjuntodeMetodos(ImprimirNome);            
            cjtMetodos += ImprimirNomeEmMaisculo;
            cjtMetodos += ImprimirNomeEmMinusculo;
            cjtMetodos(nome);
        }

        public static void ImprimirNome(string nome)
        {
            Console.WriteLine($"Nome: {nome}");
        }

        public static void ImprimirNomeEmMaisculo(string nome)
        {
            Console.WriteLine($"Nome: {nome.ToUpper()}");
        }

        public static void ImprimirNomeEmMinusculo(string nome)
        {
            Console.WriteLine($"Nome: {nome.ToLower()}");
        }
    }
}
