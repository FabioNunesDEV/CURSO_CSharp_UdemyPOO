using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using Cource;

namespace Cource
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\Users\fabio\Documents\CURSO EXERCICIOS\CURSO_CSharp_UdemyPOO\Seção 13 - Trabalhando com Arquivos\ExercicioFixacao\Cource\arquivos\PrecoUnit.csv";

            string targetPath = @"D:\Users\fabio\Documents\CURSO EXERCICIOS\CURSO_CSharp_UdemyPOO\Seção 13 - Trabalhando com Arquivos\ExercicioFixacao\Cource\arquivos\out\PrecoTotal.csv";

            List<Produto> produtos = new List<Produto>();
            using (StreamReader sr = File.OpenText(sourcePath))
            {
                while (!sr.EndOfStream)
                {
                    string linha = sr.ReadLine();
                    produtos.Add(Produto.FromCsv(linha));
                }
            }

            foreach (Produto produto in produtos)
            {
                produto.ValorTotal = produto.Preco * produto.Quant;
            }

            using (StreamWriter sw = File.AppendText(targetPath))
            {
                foreach (Produto p in produtos)
                {
                    string linha = $"{p.Nome};{p.ValorTotal.ToString("c2")}";
                    sw.WriteLine(linha);
                }                
            }
        }
    }
}
