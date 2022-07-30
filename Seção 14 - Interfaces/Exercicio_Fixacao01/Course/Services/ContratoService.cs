using System;
using Entities;

namespace Services
{
    class ContratoService
    {
        private IPagamentoOnlineService _pagamentoOnlineService;

        public ContratoService (IPagamentoOnlineService pagamentoOnlineService)
        {
            _pagamentoOnlineService = pagamentoOnlineService;
        }

        public void ProcessoContrato (Contrato contrato, int meses)
        {
            double cotaBasica = contrato.ValorTotal / meses;
            for (int i = 1; i <= meses; i++)
            {
                DateTime dataParcela = contrato.Data.AddMonths(i);
                double updateCota = cotaBasica + _pagamentoOnlineService.Parcela(cotaBasica, i);
                double fullCota = updateCota + _pagamentoOnlineService.TaxaPagamento(updateCota);
                contrato.AdcionarParcela(new Parcela(dataParcela, fullCota));
            }
        }
    }
}
