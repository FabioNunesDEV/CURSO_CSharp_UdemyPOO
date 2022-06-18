using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número de linhas da matriz: ");
            int linha = Int32.Parse(Console.ReadLine());

            Console.Write("Número de colunas da matriz: ");
            int coluna = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            string[,] matriz = new string[linha, coluna];

            for (int i = 0; i < linha; i++)
            {
                Console.Write($"Linha #{i + 1}, digite {coluna} números separados por espaço: ");

                string[] numbers = Console.ReadLine().Split(' ');

                for (int j = 0; j < coluna; j++)
                {
                    matriz[i, j] = numbers[j];
                }
            }

            Console.WriteLine();
            Console.Write("Digite número que deseja procurar: ");
            string n = Console.ReadLine();

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    if (matriz[i,j] == n)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"#{n}: linha-{i+1}, coluna-{j+1}");
                        // Verifica número acima
                        if (i > 0)
                            Console.WriteLine($"Acima: {matriz[i-1,j]}");

                        // Verifica número a direita
                        if (j < coluna-1)
                            Console.WriteLine($"Direita: {matriz[i,j+1]}");

                        // Verifica número abaixo
                        if (i < linha-1)
                            Console.WriteLine($"Abaixo: {matriz[i + 1, j]}");

                        // Verifica númenro a esquerda
                        if (j > 0)
                            Console.WriteLine($"Esquerda: {matriz[i, j - 1]}");
                    }
                }
            }
        }
    }
}
