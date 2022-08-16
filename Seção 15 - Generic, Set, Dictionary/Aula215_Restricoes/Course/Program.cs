using System;
using System.Collections.Generic;
using System.Globalization;
using Entities;
using Services;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de produtos: ");
            int n = Int32.Parse(Console.ReadLine());

            List<Produto> produtos = new List<Produto>();

            for (int i = 0; i < n; i++)
            {
                string[] vetor = Console.ReadLine().Split(',');

                string nome = vetor[0];
                double preco = double.Parse(vetor[1],CultureInfo.InvariantCulture);

                produtos.Add(new Produto(nome, preco));
            }

            CalculationService calculationService = new CalculationService();
            Produto produtoMaisCaro = calculationService.Max(produtos);

            Console.WriteLine("O mais caro: ");
            Console.WriteLine(produtoMaisCaro.ToString());

            Console.ReadKey();
        }
    }
}
