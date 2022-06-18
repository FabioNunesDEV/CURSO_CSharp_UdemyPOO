using System;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
                Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1046/uri1046/Program.cs
            
                Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
                começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

            */

            int h1, h2, dif;

            Console.Write("Digite hora de inicio: ");
            h1 = Int32.Parse(Console.ReadLine());

            Console.Write("Digite hora de termino: ");
            h2 = Int32.Parse(Console.ReadLine());

            dif = h1 - h2;

            if (h1 < h2)
                dif = h2 - h1;
            else
                dif = 24 - h1 + h2;

                Console.WriteLine($"O jogo durou {dif} hora(s)");

        }
    }
}
