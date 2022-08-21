using System;
using System.Collections.Generic;
using System.Linq;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // Representa um método que recebe zero ou mais argumentos, e retorna um valor
            // public delegate TResult Func<out TResult>();
            // public delegate TResult Func<in T1,in T2...,inT16, out TResult>(T obj); até 16 argumentos.

            //Func<Product, string> func = NameUpper;
            //List<string> result = list.Select(func).ToList();

            //Func<Product, string> func = p => p.Name.ToUpper();
            //List<string> result = list.Select(func).ToList();

            List<string> result = list.Select(p =>  p.Name.ToUpper()).ToList();

            //List<string> result = list.Select(NameUpper).ToList();

            foreach (string item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
