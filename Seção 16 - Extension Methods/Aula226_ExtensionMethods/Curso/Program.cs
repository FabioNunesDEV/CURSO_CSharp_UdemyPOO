using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datePost = new DateTime(2022, 08, 18, 07, 40, 00);
            Console.WriteLine("Time elapsed: " + datePost.ElapsedTime());

            string txt = "Good morning dear stundents !";
            Console.WriteLine("Resume: " + txt.Cut(10));

            Console.ReadLine();
        }
    }
}
