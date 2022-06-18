using System;
using System.Globalization;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159;
            double a, b, c, aTriang, aCirc, aTrap, aQuadr, aRetang;

            string[] valores = Console.ReadLine().Split(' ');

            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            aTriang = (a * c) / 2;
            aCirc = PI * c * c;
            aTrap = ((a + b) * c) / 2;
            aQuadr = b * b;
            aRetang = a * b;

            Console.WriteLine("Tringulo.:" + aTriang.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Circulo..:" + aCirc.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapezio.:" + aTrap.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado.:" + aQuadr.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("retangulo:" + aRetang.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
