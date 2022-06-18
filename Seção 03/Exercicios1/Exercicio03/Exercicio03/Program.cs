using System;
using System.Globalization;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, dif;

            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            c = Int32.Parse(Console.ReadLine());
            d = Int32.Parse(Console.ReadLine());

            dif = a * b - c * d;

            Console.WriteLine("Diferença: " + dif);
        }
    }
}
