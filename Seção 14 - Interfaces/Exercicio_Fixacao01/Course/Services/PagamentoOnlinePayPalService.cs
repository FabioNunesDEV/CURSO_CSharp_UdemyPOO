using System;

namespace Services
{
    class PagamentoOnlinePayPalService : IPagamentoOnlineService
    {
        private const double TaxaCobranca = 0.02;
        private const double TaxaMensal = 0.01;
        public double Parcela(double valor, int meses)
        {
            return valor * TaxaMensal * meses;
        }

        public double TaxaPagamento(double valor)
        {
            return valor * TaxaCobranca;
        }
    }
}
