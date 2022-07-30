using System.Globalization;

namespace Entities
{
    class Nota
    {
        public double PagamentoBasico { get; set; }
        public double Taxa { get; set; }

        public Nota(double pagamentoBasico, double taxa)
        {
            PagamentoBasico = pagamentoBasico;
            Taxa = taxa;
        }

        public double PagamentoTotal
        {
            get { return PagamentoBasico + Taxa; }
        }

        public override string ToString()
        {
            return $"Pagamento Básico: {PagamentoBasico.ToString("F2",CultureInfo.InvariantCulture)}" +
                   $"\nTaxa: {Taxa.ToString("F2",CultureInfo.InvariantCulture)}" +
                   $"\nPagamento total: {PagamentoTotal.ToString("F2",CultureInfo.InvariantCulture)}"; 
        }
    }
}
