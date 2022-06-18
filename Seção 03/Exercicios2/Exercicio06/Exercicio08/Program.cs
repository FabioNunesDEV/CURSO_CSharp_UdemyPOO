using System;
using System.Globalization;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             

            Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1037/uri1037/Program.cs

            Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
            seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
            nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.


             */

            double n;

            Console.Write("Digite um número: ");
            n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (n< 0.0 || n>100.0)
            {
                Console.WriteLine("Fora do limite.");
            }
            else if (n <= 25.0)
            {
                Console.WriteLine("Intervalo 0 -> 25");
            }
            else if (n <= 50.0)
            {
                Console.WriteLine("Intervalo 25.01 -> 50");
            }
            else if (n <= 75)
            {
                Console.WriteLine("Intervalo 50.01 -> 75");
            }
            else
            {
                Console.WriteLine("Intervalo 75.01 -> 100");
            }
        }
    }
}
