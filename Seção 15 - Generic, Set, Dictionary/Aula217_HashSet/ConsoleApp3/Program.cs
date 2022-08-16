using System;
using System.Text;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> conjunto = new HashSet<string>();

            conjunto.Add("TV");
            conjunto.Add("Notebook");
            conjunto.Add("Tablet");
            conjunto.Add("Desktop");
            conjunto.Add("TV");

            Console.WriteLine("HashSet produtos: " );
            PrintColletion(conjunto);            

            Console.WriteLine("Contains (Notebook): " + conjunto.Contains("Notebook"));

            Console.ReadKey();
        }

        static void PrintColletion<T>(IEnumerable<T> colecao)
        {
            List<T> lista = new List<T>();

            foreach (T obj in colecao)
            {
                lista.Add(obj);
                
            }

            for (int i = 0; i < lista.Count-1; i++)
            {
                Console.Write(lista[i] + ", ");
            }

            Console.WriteLine(lista[lista.Count - 1]);
        }
    }
}
