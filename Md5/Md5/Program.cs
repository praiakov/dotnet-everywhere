using System;

namespace Md5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("##### MD5 Hash #####");
            
            Console.WriteLine("Digite sua senha:");
            
            var pass = Console.ReadLine();

            Console.WriteLine($"{getMD5Hash(pass)}");
        }

        public static string getMD5Hash(string input)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }

    }
}
