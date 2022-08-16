using System;
using System.Collections.Generic;
using System.IO;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Users\fabio\Documents\CURSO EXERCICIOS\CURSO_CSharp_UdemyPOO\Seção 15 - Generic, Set, Dictionary\Aula223_ExProposto\Curso\Votos.txt";
            Dictionary<string, Int32> votos = new Dictionary<string, int>();
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] vetor = sr.ReadLine().Split(',');
                    string candidato = vetor[0];
                    int quantidadeVotos = Int32.Parse(vetor[1]);

                    if (votos.ContainsKey(vetor[0]))
                    {
                        
                        votos[candidato] += quantidadeVotos;
                    }
                    else
                    {
                        votos[candidato] = quantidadeVotos;
                    }
                }
            }

            Console.WriteLine("Apuração de votos:");
            foreach (var soma in votos)
            {
                Console.WriteLine($"{soma.Key}: {soma.Value}");
            }

            Console.ReadKey();
        }
    }
}
