using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa a, b;

            a = new Pessoa();
            b = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa.");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            a.Idade = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa.");
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            b.Idade = Int32.Parse(Console.ReadLine());

            if (a.Idade > b.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {a.Nome}");
            }
            else if (b.Idade > a.Idade )
            {
                Console.WriteLine($"Pessoa mais velha: {b.Nome}");
            }
            else
            {
                Console.WriteLine($"{a.Nome} e {b.Nome} tem a mesma idade.");
            }
        }
    }
}
