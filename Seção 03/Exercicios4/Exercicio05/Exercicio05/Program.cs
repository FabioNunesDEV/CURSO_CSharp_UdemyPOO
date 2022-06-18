using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int m = 1;

            for (int i = n; i >= 1; i--)
            {
                m *= i;
            }

            Console.WriteLine($"Fatorial de {n} é {m}");
        }
    }
}
