using System;
using System.Globalization;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] peca1 = Console.ReadLine().Split(' ');
            string[] peca2 = Console.ReadLine().Split(' ');

            int cod1, cod2, pc1, pc2;
            double vl1, vl2, vlTotal;

            cod1 = Int32.Parse(peca1[0]);
            pc1 = Int32.Parse(peca1[1]);
            vl1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

            cod2 = Int32.Parse(peca2[0]);
            pc2 = Int32.Parse(peca2[1]);
            vl2 = double.Parse(peca2[2],CultureInfo.InvariantCulture);

            vlTotal = (pc1 * vl1) + (pc2 * vl2);

            Console.WriteLine("Valor a pagar: R$ " + vlTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
