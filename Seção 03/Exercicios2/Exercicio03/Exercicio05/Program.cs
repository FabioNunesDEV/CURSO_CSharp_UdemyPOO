using System;


namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1044/uri1044/Program.cs
            /*
                Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
                Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
                ordem crescente ou decrescente.
            */

            int n1, n2;

            Console.Write("Digite o primeiro número: ");
            n1 = Int32.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            n2 = Int32.Parse(Console.ReadLine());


            if (n1 % n2 == 0 || n2 % n1 == 0)
                Console.WriteLine("São multiplos");
            else
                Console.WriteLine("Não são multiplos.");
        }
    }
}
