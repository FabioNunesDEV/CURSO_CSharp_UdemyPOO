using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int gasolina = 0, alcool=0, diesel=0, opcao=0;

            Console.WriteLine("Opções 1-Gasolina, 2-alcool, 3-diesel, 4-fim: ");
            do
            {
                Console.Write("Digite: ");
                opcao = Int32.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        gasolina++;
                        break;
                    case 2:
                        alcool++;
                        break;
                    case 3:
                        diesel++;
                        break;
                    case 4:
                        Console.WriteLine("Muito obrigado !");
                        Console.WriteLine("Gasolina: " + gasolina);
                        Console.WriteLine("Alcool..: " + alcool);
                        Console.WriteLine("Diesel..: " + diesel);
                        break;
                    default:
                        Console.WriteLine("Opção invalida !");
                        break;
                }

            } while (opcao != 4);

        }
    }
}
