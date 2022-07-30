using System;
using System.Globalization;
using Entities;
using Services;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do aluguel:");
            Console.Write("Modelo do veiculo: ");
            string modelo = Console.ReadLine();
            Console.Write("Data de retirada (dd/mm/aaaa hh:mm): ");
            DateTime retirada = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Data de devolução (dd/mm/aaaa hh:mm): ");
            DateTime devolucao = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Informe o preço por hora: ");
            double precoHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o preço por dia: ");
            double precoDia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            LocacaoVeiculo locacaoVeiculo = new LocacaoVeiculo(retirada, devolucao, new Veiculo(modelo));

            LocacaoService locacaoService = new LocacaoService(precoHora, precoDia, new BrasilTaxaService());

            locacaoService.Fatura(locacaoVeiculo);

            Console.WriteLine("Nota Fiscal: ");
            Console.WriteLine(locacaoVeiculo.Nota);

            Console.ReadKey();
        }
    }
}
