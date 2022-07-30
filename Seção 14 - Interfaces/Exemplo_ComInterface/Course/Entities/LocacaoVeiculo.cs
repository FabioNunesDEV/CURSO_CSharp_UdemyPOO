using System;

namespace Entities
{
    class LocacaoVeiculo
    {
        public DateTime Retirada { get; set; }
        public DateTime Devolucao { get; set; }
        public Veiculo Veiculo { get; set; }
        public Nota Nota { get; set; }

        public LocacaoVeiculo(DateTime retirada, DateTime devolucao, Veiculo veiculo)
        {
            Retirada = retirada;
            Devolucao = devolucao;
            Veiculo = veiculo;
            Nota = null;
        }
    }
}
