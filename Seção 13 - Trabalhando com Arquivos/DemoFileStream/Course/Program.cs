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
            Console.WriteLine("Tecle em qualqer tecla para sair.");
            Console.ReadKey();
        }

        static void Demo1()
        {
            string path = @"..\..\..\..\arquivos\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate);
                sr = new StreamReader(fs);

                string line = sr.ReadToEnd();
                Console.WriteLine(line);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) sr.Close();
            }
        }

        static void Demo2()
        {
            string path = @"..\..\..\..\arquivos\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate);
                sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) sr.Close();
            }
        }

        // Tornando o codigo mais enxuto com o uso da classe auxiliar File ao invés do FileStream.
        static void Demo3()
        {
            string path = @"..\..\..\..\arquivos\file1.txt";

            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr != null) sr.Close(); 
            }
        }
    }
}
