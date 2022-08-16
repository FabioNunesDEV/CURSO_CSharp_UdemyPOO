using System;
using System.Collections.Generic;
using System.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de alunos curso A: ");
            HashSet<Int32> cursoA = new HashSet<int>();
            Int32 nroA = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < nroA; i++)
            {
                Int32 codigoAluno = Int32.Parse(Console.ReadLine());
                cursoA.Add(codigoAluno);
            }

            Console.Write("Quantidade de alunos curso B: ");
            HashSet<Int32> cursoB = new HashSet<int>();
            Int32 nroB = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < nroB; i++)
            {
                Int32 codigoAluno = Int32.Parse(Console.ReadLine());
                cursoB.Add(codigoAluno);
            }

            Console.Write("Quantidade de alunos curso C: ");
            HashSet<Int32> cursoC = new HashSet<int>();
            Int32 nroC = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < nroC; i++)
            {
                Int32 codigoAluno = Int32.Parse(Console.ReadLine());
                cursoC.Add(codigoAluno);
            }

            HashSet<Int32> totalAlunos = new HashSet<int>();

            totalAlunos.UnionWith(cursoA);
            totalAlunos.UnionWith(cursoB);
            totalAlunos.UnionWith(cursoC);

            Console.WriteLine();
            Console.WriteLine("Total de alunos : " + totalAlunos.Count);

            Int32[] alunos = totalAlunos.ToArray();
            string colecao = string.Join(',',alunos);

            Console.WriteLine("[ " + colecao + " ]");

            Console.ReadKey();            
        }
    }
}
