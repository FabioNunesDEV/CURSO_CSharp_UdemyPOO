using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                double div = i % 2;
                if (div != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
