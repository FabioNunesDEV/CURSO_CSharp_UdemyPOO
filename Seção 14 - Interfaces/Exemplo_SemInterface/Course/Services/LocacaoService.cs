using System;
using Entities;

namespace Services
{
    class LocacaoService
    {
        public double PrecoPorHora { get; private set; }
        public double PrecoPorDia { get; private set; }
        private BrasilTaxaService _brasilTaxaService = new BrasilTaxaService();

        public LocacaoService(double precoPorHora, double precoPorDia)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
        }

        public void Fatura(LocacaoVeiculo locacaoVeiculo)
        {
            TimeSpan duracao = locacaoVeiculo.Devolucao.Subtract(locacaoVeiculo.Retirada);

            double pagamentoBasico = 0.0;

            if (duracao.TotalHours <= 12.0)
            {
                pagamentoBasico = PrecoPorHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                pagamentoBasico = PrecoPorDia * Math.Ceiling(duracao.TotalDays);
            }

            double taxa = _brasilTaxaService.Taxa(pagamentoBasico);

            locacaoVeiculo.Nota = new Nota(pagamentoBasico, taxa);
        }
    }
}
