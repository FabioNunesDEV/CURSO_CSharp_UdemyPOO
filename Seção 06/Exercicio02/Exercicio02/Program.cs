using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered ?: ");
            int nroRegisters = Int32.Parse(Console.ReadLine());

            List<Funcionario> lstEmployees = new List<Funcionario>();


            for (int i = 0; i < nroRegisters; i++)
            {
                Funcionario func = new Funcionario();
                Console.Write("Id: ");
                func.Id = Int32.Parse(Console.ReadLine());

                Console.Write("Name: ");
                func.Name = Console.ReadLine();

                Console.Write("Salary: ");
                func.Salary = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                lstEmployees.Add(func);
                Console.WriteLine("");
            }

            Console.WriteLine("Enter the employee id that will have salary increase: ");
            int id = Int32.Parse(Console.ReadLine());

            int index = lstEmployees.FindIndex(x => x.Id == id);

            // Verifica se o funcionario existe.
            if (index > -1)
            {
                Console.WriteLine("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lstEmployees[index].Salary = lstEmployees[index].Salary * (1+(percentage/100));
            }
            else
            {
                Console.WriteLine("This id does not exist ! ");
            }

            Console.WriteLine("");
            Console.WriteLine("Updated list of employees: ");

            foreach (var item in lstEmployees)
            {
                Console.WriteLine(item);
            }
        }
    }
}
