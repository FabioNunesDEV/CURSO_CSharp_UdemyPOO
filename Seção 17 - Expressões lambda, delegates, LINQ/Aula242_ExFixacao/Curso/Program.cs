using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.IO;
using Entities;


namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Users\fabio\Documents\CURSO EXERCICIOS\CURSO_CSharp_UdemyPOO\Seção 17 - Expressões lambda, delegates, LINQ\Aula242_ExFixacao\Curso\in.csv";

            List<Employee> employees = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] vetor = sr.ReadLine().Split(',');
                        employees.Add(new Employee()
                        {
                            Name = vetor[0],
                            Email = vetor[1],
                            Salary = double.Parse(vetor[2], CultureInfo.InvariantCulture)
                        });
                    }
                }

                Console.Write("Enter salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Email of people whose salary is more than " + salary.ToString("F2", CultureInfo.InvariantCulture));

                var r1 = employees.Where(e => e.Salary >= salary).OrderBy(p => p.Email);

                foreach (var item in r1)
                {
                    Console.WriteLine(item);
                }

                var r2 = employees.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);

                Console.WriteLine("Sum of salary of people whose name starts with 'M': " + r2.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
