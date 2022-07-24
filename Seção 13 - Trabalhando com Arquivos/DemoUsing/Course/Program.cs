using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo2();
            Console.WriteLine();
            Console.WriteLine("Tecla qualquer tecla para sair.");
            Console.ReadKey();
        }

        static void Demo1()
        {
            string path = @"..\..\..\..\Arquivos\file1.txt";

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Um erro ocorreu.");
                Console.WriteLine(ex.Message);

            }
        }

        static void Demo2()
        {
            string path = @"..\..\..\..\Arquivos\file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Um erro ocorreu.");
                Console.WriteLine(ex.Message);

            }
        }
    }
}
