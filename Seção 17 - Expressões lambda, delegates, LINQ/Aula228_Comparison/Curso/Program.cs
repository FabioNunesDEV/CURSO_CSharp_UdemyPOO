using System;
using Identitie;
using System.Collections.Generic;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            produtos.Add(new Produto("Televisão", 1500.00));
            produtos.Add(new Produto("Rádio", 500.00));
            produtos.Add(new Produto("Celular", 1200.00));

            // Usa o método IComparable da classe.
            // produtos.Sort() 

            // Usa o método static CompararProdutos.
            // produtos.Sort(ComaprarProdutos) - Delegate comparison -> int comparison<t>(t1,t2);

            // Outras simplificações até chegar um clausula lambda.
            
            // Comparison<Produtos> prod = CompararProdutos;
            // produtos.Sort(prod);
            
            // Comparison<Produtos> prod = (p1,p2)=>p1.Preco.CompareTo(p2.preco);
            // produtos.Sort(prod);

            // Versão resumida.
            produtos.Sort((p1,p2)=> p2.Preco.CompareTo(p1.Preco));

            foreach (var item in produtos)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }

        static int CompararProdutos(Produto p1, Produto p2)
        {
            return p2.Preco.CompareTo(p1.Preco);
        }
    }
}
