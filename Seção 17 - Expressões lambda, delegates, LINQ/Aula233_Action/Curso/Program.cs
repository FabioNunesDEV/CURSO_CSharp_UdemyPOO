using System;
using System.Collections.Generic;

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

            // Action representa um método void que receber zero ou mais argumentos.
            // public delegate void Action<in T>(T obj,..); 16 sobrecargas
            // list.ForEach(p => p.Price += p.Price * 0.1);

            // Método alternativo.
            list.ForEach(UpdatePrice);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        static void UpdatePrice (Product p)
        {
            p.Price += p.Price * 0.1; 
        }
    }
}
