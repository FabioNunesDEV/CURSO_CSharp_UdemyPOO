using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos valores você irá digitar ?: ");
            int vezes = Int32.Parse(Console.ReadLine());

            PrintService<int> printService1 = new PrintService<int>();

            for (int i = 0; i < vezes; i++)
            {
                int valor = Int32.Parse(Console.ReadLine());
                printService1.AddValor(valor);
            }

            printService1.Print();
            Console.WriteLine(printService1.First());

            Console.WriteLine();
            Console.WriteLine(new string("-"), 40);
            Console.WriteLine();

            Console.Write("Quantos nomes você irá digitar ?: ");
            vezes = Int32.Parse(Console.ReadLine());

            PrintService<string> printService2 = new PrintService<string>();

            for (int i = 0; i < vezes; i++)
            {
                string nome = Console.ReadLine();
                printService2.AddValor(nome);
            }

            printService2.Print();
            Console.WriteLine(printService2.First());

            Console.ReadKey();
        }
    }
}
