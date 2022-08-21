using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Entities;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lendo arquivo in.csv");
            string path = @"D:\Users\fabio\Documents\CURSO EXERCICIOS\CURSO_CSharp_UdemyPOO\Seção 17 - Expressões lambda, delegates, LINQ\Aula241_ExResolvido\Curso\in.csv";

            List<Product> products = new List<Product>();
            int contador = 0;
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] vector = sr.ReadLine().Split(",");
                    contador++;
                    products.Add(new Product()
                    {
                        Id = contador,
                        Name = vector[0],
                        Price = double.Parse(vector[1],CultureInfo.InvariantCulture)
                    });
                }
            }

            var r1 = products.Average(x => x.Price);
            Console.WriteLine("Average Price: " + r1.ToString("F2", CultureInfo.InvariantCulture));

            var r2 = products.Where(p => p.Price <= r1).OrderByDescending(p=>p.Name).Select(p=>p.Name);

            foreach (var item in r2)
            {
                Console.WriteLine( item );
            }

            Console.ReadKey();

        }
    }
}
