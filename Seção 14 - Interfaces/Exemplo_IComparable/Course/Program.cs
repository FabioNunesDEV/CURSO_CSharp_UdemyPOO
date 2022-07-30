using System;
using System.Collections.Generic;
using System.IO;
using Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../Funcionarios.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Funcionario> lista = new List<Funcionario>();

                    while (!sr.EndOfStream)
                    {
                        lista.Add(new Funcionario(sr.ReadLine()));
                    }

                    lista.Sort();

                    foreach (Funcionario item in lista)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro !");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Precione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
