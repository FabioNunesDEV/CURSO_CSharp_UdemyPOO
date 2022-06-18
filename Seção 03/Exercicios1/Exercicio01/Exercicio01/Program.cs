using System;
using System.Globalization;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, soma;

            Console.Write("Digite um número inteiro: ");
            n1 = Int32.Parse(Console.ReadLine());

            Console.Write("Digite um número inteiro: ");
            n2 = Int32.Parse(Console.ReadLine());

            soma = n1 + n2;

            Console.WriteLine($"Soma {n1} + {n2} = {soma}");
        }
    }
}
