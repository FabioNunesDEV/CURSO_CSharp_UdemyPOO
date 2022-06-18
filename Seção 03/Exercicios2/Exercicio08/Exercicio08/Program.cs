using System;
using System.Globalization;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, imposto;

            salario = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 2000)
            {
                Console.WriteLine("Isento");
            }
            else if (salario <=3000)
            {
                imposto = (salario - 2000) * 0.8;

                Console.WriteLine("R$ " + imposto.ToString("F2",CultureInfo.InvariantCulture));
            }
            else if (salario <= 4500)
            {
                imposto = (salario - 3000) * 0.18 + 1000 * 0.08;

                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                imposto = (salario - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;

                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
