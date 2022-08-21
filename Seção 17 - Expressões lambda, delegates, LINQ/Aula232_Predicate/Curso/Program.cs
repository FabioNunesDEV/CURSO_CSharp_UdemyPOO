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

            // usando o Predicate
            //list.RemoveAll(p => p.Price >= 100.0);

            // usando método alternativo.
            list.RemoveAll(Predicado);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            Console.ReadKey();
        }

        // Um Predicate representa um método que recebe um objeto do tipo T e retorna um valor booleano.
        // public delegate bool Predicate<in T>(T obj);
        static bool Predicado (Product p)
        {
            return p.Price >= 100.00;
        }
    }
}
