using System;
using System.Globalization;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("digite as três notas do aluno: ");
            aluno.Trim1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Trim2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Trim3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL: " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(aluno.Status());
            if (aluno.Status() == "REPROVADO")
            {
                Console.WriteLine("FALTARAM " + aluno.Falta().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
