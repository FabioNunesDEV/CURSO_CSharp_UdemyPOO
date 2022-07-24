using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoFileInfo();
            Console.WriteLine();
            Console.WriteLine("Tecla qualquer tecla para sair.");
            Console.ReadKey();
        }

        // Faz uso da classe static File (mais lenta pois faz verificação de segurança todas as vezes que é usada)
        static void DemoFile()
        {
            string sourcePath = @"..\..\..\..\Arquivos\file1.txt";
            string targetPath = @"..\..\..\..\Arquivos\file2.txt";

            try
            {
                File.Copy(sourcePath, targetPath);
                string[] lines = File.ReadAllLines(targetPath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine(ex.Message);
            }
        }

        // Faz uso da classe instanciada FileInfo (mais rápida pois faz verificação de segurança só quando é instanciada)
        static void DemoFileInfo()
        {
            string sourcePath = @"..\..\..\..\Arquivos\file1.txt";
            string targetPath = @"..\..\..\..\Arquivos\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath, true);

                string[] lines = File.ReadAllLines(targetPath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine(ex.Message);
            }
        }


    }
}
