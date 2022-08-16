using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos valores você irá digitar ?: ");
            int vezes = Int32.Parse(Console.ReadLine());

            PrintService printService = new PrintService();

            for (int i = 0; i < vezes; i++)
            {
                int valor = Int32.Parse(Console.ReadLine());
                printService.AddValor(valor);
            }

            printService.Print();
            Console.WriteLine(printService.First());

            Console.ReadKey();
        }
    }
}
