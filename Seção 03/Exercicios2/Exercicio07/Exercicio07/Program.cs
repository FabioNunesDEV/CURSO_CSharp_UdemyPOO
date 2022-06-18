using System;
using System.Globalization;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x >0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x>0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (x<0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if(x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }

        }
    }
}
