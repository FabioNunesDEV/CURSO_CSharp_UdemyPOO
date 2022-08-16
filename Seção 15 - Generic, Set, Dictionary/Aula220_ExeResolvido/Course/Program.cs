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
            string caminho = @"D:\Users\fabio\Documents\CURSO EXERCICIOS\CURSO_CSharp_UdemyPOO\Seção 15 - Generic, Set, Dictionary\Aula220_ExeResolvido\Course\RegistrosLog.txt";

            HashSet<Registro> conj = new HashSet<Registro>();
            using (StreamReader sr = File.OpenText(caminho))
            {
                while (!sr.EndOfStream)
                {
                    
                    string[] vetor = sr.ReadLine().Split(' ');
                    string nome = vetor[0];
                    DateTime instante = DateTime.Parse(vetor[1]);

                    Console.WriteLine(nome + " - " + instante);

                    conj.Add(new Registro(nome, instante));
                }
            }

            Console.WriteLine("Total de usuários: " + conj.Count);
            Console.ReadKey();
        }
    }
}
