using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados?: ");
            int quantQuartos = Int32.Parse(Console.ReadLine());

            Quarto[] quartos = new Quarto[10];

            for (int i = 0; i < quantQuartos; i++)
            {
                Quarto quarto = new Quarto();
                Console.WriteLine($"Aluguel #{i + 1}");

                Console.Write("Nome: ");
                quarto.Nome = Console.ReadLine();

                Console.Write("E-mail:");
                quarto.Email = Console.ReadLine();

                Console.Write("Quarto [0-9]: ");
                quarto.NroQuarto = Int32.Parse(Console.ReadLine());

                quartos[quarto.NroQuarto] = quarto;
            }

            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < quartos.Length; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine(quartos[i]);
                }
            }
        }
    }
}
