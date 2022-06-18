using System;
using System.Globalization;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/cond01/cond01/Program.cs
            // Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

            int n;

            Console.Write("Digite um numero (positivo ou negativo): ");
            n = Int32.Parse(Console.ReadLine());

            if (n < 0)
                Console.WriteLine("Negativo");
            else
                Console.WriteLine("Positivo");
        }
    }
}
