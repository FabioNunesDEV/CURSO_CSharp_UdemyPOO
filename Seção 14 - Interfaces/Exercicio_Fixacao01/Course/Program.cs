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
            Console.WriteLine("Entre com os dados do contrato.");
            Console.Write("Número: ");
            int nroContrato = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime dataContrato = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor contrato: ");
            double valorContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o número de parcelas: ");
            int meses = int.Parse(Console.ReadLine());

            Contrato meuContrato = new Contrato(nroContrato, dataContrato, valorContrato);

            ContratoService contratoService = new ContratoService(new PagamentoOnlinePayPalService());
            contratoService.ProcessoContrato(meuContrato, meses);

            Console.WriteLine("Parcelas:");
            foreach (Parcela parcela in meuContrato.Parcelas)
            {
                Console.WriteLine(parcela);
            }

            Console.WriteLine("Precione qualquer tecla para sair: ");
            Console.ReadKey();
        }
    }
}
