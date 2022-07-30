namespace Services
{
    interface IPagamentoOnlineService
    {
        public double TaxaPagamento(double valor);
        public double Parcela(double valor, int meses);
    }
}
