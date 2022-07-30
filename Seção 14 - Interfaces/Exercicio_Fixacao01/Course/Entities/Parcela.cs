using System;
using System.Globalization;

namespace Entities
{
    class Parcela
    {
        public DateTime Vencimento { get; set; }
        public double Valor { get; set; }

        public Parcela(DateTime vencimento, double valor)
        {
            this.Vencimento = vencimento;
            this.Valor = valor;
        }

        public override string ToString()
        {
            return Vencimento.ToString("dd/MM/yyyy") + " - " + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
