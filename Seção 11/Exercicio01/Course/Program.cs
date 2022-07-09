using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite dois números para serem divididos:");
                Console.Write("Nº1: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Nº2: ");
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine("");
                Console.WriteLine("O resultado é: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divisão por zero não é possivel.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Digite apenas números.");
            }

            Console.ReadKey();
        }
    }
}
