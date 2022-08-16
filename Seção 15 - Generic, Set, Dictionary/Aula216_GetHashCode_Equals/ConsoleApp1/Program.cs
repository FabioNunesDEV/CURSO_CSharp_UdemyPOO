using System;
using Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente a = new Cliente("Fabio", "fabio.nunes@silo.com.vc");
            Cliente b = new Cliente("Daniela", "danierepettobr@gmail.com");
            Cliente c = new Cliente("Fabio", "fabio.nunes@silo.com.vc");

            Console.WriteLine("Comparando a com b");
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            Console.WriteLine(new string('-',40));

            Console.WriteLine("Comparando a com c");
            Console.WriteLine(a.Equals(c));
            Console.WriteLine(a == c);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(c.GetHashCode());

            Console.ReadKey();
        }
    }
}
