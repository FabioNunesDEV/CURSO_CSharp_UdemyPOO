using System;
using System.Globalization;

namespace ContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            Conta conta;

            Console.Write("Entre o número da conta: ");
            string nroConta = Console.ReadLine();

            Console.Write("Entre o títular da conta: ");
            string nomeTitular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string depositoSN = Console.ReadLine();

            if (depositoSN.ToLower() == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(nroConta, nomeTitular, valor);
            }
            else
            {
                conta = new Conta(nroConta, nomeTitular);
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta.ToString());

            Console.Write("Entre um valor para depósito:");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valor);
            Console.WriteLine("Dados da conta atulizados:");
            Console.WriteLine(conta.ToString());

            Console.Write("Entre um valor para saque:");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valor);
            Console.WriteLine("Dados da conta atulizados:");
            Console.WriteLine(conta.ToString());
        }
    }
}
