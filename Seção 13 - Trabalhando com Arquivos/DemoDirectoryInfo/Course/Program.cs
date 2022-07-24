using System;
using System.IO;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo2();

            Console.WriteLine();
            Console.WriteLine("Tecle em qualqer tecla para sair.");
            Console.ReadKey();
        }

        static void Demo1()
        {
            string path = @"..\..\..\arquivos\";

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path,"*.*",SearchOption.AllDirectories);

                Console.WriteLine("Pastas:");
                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Arquivos:");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(ex.Message);
            }
        }

        static void Demo2()
        {
            string path = @"..\..\..\arquivos\";

            try
            {
                Console.WriteLine("Pastas/Arquivos:");
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                    
                    IEnumerable<string> files = Directory.EnumerateFiles(folder, "*.*", SearchOption.AllDirectories);
                    foreach (string file in files)
                    {                        
                        Console.WriteLine("-> " + file);
                    }

                    Console.WriteLine();
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
