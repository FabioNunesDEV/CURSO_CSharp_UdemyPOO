using System;
using System.Globalization;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, a;
            const double PI = 3.14159;

            Console.Write("Digite o raio de um circulo: ");
            r = double.Parse( Console.ReadLine(),CultureInfo.InvariantCulture);
            a = PI * r * r;

            Console.WriteLine("Area = " + a.ToString("F4",CultureInfo.InvariantCulture));

        }
    }
}
