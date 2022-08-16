using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int> { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int> { 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("SortedSet");
            Console.Write("Conjunto a: ");
            PrintCollection(a);

            Console.Write("Conjuto b: ");
            PrintCollection(b);

            //union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            Console.WriteLine();
            Console.Write("a união b: ");            
            PrintCollection(c);

            // intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            Console.WriteLine();
            Console.Write("a intersecção b: ");
            PrintCollection(d);

            // exceção
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            Console.WriteLine();
            Console.Write("a exceção b: ");
            PrintCollection(e);

            Console.ReadKey();
        }

        static void PrintCollection<T> (IEnumerable<T> colecao)
        {
            foreach (T obj in colecao)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
