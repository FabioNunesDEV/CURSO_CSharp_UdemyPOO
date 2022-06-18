using System;
using System.Globalization;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] pares = Console.ReadLine().Split(' ');

                int n1 = Int32.Parse(pares[0]);
                int n2 = Int32.Parse(pares[1]);

                if (n2 != 0)
                {
                    double div = (double)n1 / n2;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Divisão impossivel !");
                }
                
            }
        }
    }
}
