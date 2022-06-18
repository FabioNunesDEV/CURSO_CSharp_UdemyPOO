using System;
using System.Globalization;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
                Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1038/uri1038/Program.cs
            
                Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
                seguir, calcule e mostre o valor da conta a pagar.


                código      especificação       preço
                1           cachorro quente     $ 4.00
                2           x-salada            $ 4.50
                3           x-bacon             $ 5.00
                4           torrada simples     $ 2.00
                5           refrigerante        $ 1.50
              
             */

            int cod, quant;
            double valor=0;

            Console.Write("Digite o código do lanche: ");
            cod = Int32.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade: ");
            quant = Int32.Parse(Console.ReadLine());

            switch (cod)
            {
                case 1:
                    valor = 4.00 * quant;
                    break;
                case 2:
                    valor = 4.50 * quant;
                    break;
                case 3:
                    valor = 5.00 * quant;
                    break;
                case 4:
                    valor = 2.00 * quant;
                    break;
                case 5:
                    valor = 1.50 * quant;
                    break;
                default:
                    break;
            }

            Console.Write("Total R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
