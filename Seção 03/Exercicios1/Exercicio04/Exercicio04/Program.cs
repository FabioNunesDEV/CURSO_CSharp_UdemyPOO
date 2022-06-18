using System;
using System.Globalization;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int codFuncionario, horasTrabalhadas;
            double valorHora, salario;

            codFuncionario = Int32.Parse(Console.ReadLine());
            horasTrabalhadas = Int32.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horasTrabalhadas * valorHora;

            Console.WriteLine("NUMBER = " + codFuncionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2",CultureInfo.InvariantCulture)) ;

        }
    }
}
