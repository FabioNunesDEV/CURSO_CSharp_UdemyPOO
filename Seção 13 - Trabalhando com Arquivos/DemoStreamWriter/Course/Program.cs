using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo1();
            Console.WriteLine();
            Console.WriteLine("Tecle qualquer tecla para sair.");
            Console.ReadKey();
        }

        static void Demo1()
        {
            string sourceFile = @"..\..\..\..\arquivos\file1.txt";
            string targetFile = @"..\..\..\..\arquivos\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourceFile);
                using (StreamWriter sw = File.AppendText(targetFile))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Um erro ocorreu !");
                Console.WriteLine(ex.Message);                
            }
        }
    }
}
