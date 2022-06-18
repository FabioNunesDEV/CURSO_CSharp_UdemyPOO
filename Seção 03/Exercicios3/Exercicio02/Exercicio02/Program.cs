using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            do
            {
                string[] coordenadas = Console.ReadLine().Split();

                x = Int32.Parse(coordenadas[0]);
                y = Int32.Parse(coordenadas[1]);

                if (x == 0 || y == 0)
                    Console.WriteLine("FIM");
                else if (x > 0 && y > 0)
                    Console.WriteLine("Primeiro");
                else if (x < 0 && y > 0)
                    Console.WriteLine("Segundo");
                else if (x < 0 && y < 0)
                    Console.WriteLine("Terceiro");
                else
                    Console.WriteLine("Quarto");

            } while (x != 0 && y != 0);

        }
    }
}
