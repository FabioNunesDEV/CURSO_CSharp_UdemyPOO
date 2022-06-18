using System;
using System.Globalization;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            string senhaValida, senha;

            senhaValida = "2002";

            senha = Console.ReadLine();

            while (senha != senhaValida)
            {
                Console.WriteLine("Senha invalida !");

                senha = Console.ReadLine();
            }

            Console.Write("Senha válida.");
        }
    }
}
