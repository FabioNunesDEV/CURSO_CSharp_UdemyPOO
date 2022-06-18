using System;
using System.Globalization;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, div;

            Console.Write("Digite um númenro inteiro: ");
            n = Int32.Parse(Console.ReadLine());

            div = n % 2;

            if (div > 0)
                Console.WriteLine("Impar");
            else
                Console.WriteLine("Par");
        }
    }
}
