using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Produto> a = new HashSet<Produto>();
            a.Add(new Produto("TV", 1200.00));
            a.Add(new Produto("IPhone", 2000.00));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(10, 5));
            b.Add(new Point(25, 15));

            Produto prod = new Produto("IPhone", 2000.00);
            Console.WriteLine(a.Contains(prod));

            Point ponto = new Point(25, 15);
            Console.WriteLine(b.Contains(ponto));

            Console.ReadKey();
        }
    }
}
