using System;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                double div = n % i;
                if (div == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
