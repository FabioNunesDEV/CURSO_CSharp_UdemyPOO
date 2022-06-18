using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int _in = 0;
            int _out = 0;
            int x = 0;
            int y = 0;

            x = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                y = Int32.Parse(Console.ReadLine());
                if (y>10 && y<20)
                {
                    _in++;
                }
                else
                {
                    _out++;
                }
            }

            Console.WriteLine(_in + " in");
            Console.WriteLine(_out + " out");           
        }
    }
}
