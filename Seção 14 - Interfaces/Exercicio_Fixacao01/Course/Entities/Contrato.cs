using System;
using System.Collections.Generic;

namespace Entities
{
    class Contrato
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }
        public List<Parcela> Parcelas { get; set; } = new List<Parcela>();

        public Contrato(int numero, DateTime data, double valorTotal)
        {
            this.Numero = numero;
            this.Data = data;
            this.ValorTotal = valorTotal;
            this.Parcelas = new List<Parcela>();
        }

        public void AdcionarParcela (Parcela parcela)
        {
            Parcelas.Add(parcela);
        }
    }
}
