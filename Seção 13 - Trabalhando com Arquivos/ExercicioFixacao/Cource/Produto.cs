using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cource
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quant { get; set; }
        public double ValorTotal { get; set; }
        public static Produto FromCsv(string produtoLine)
        {
            string[] values = produtoLine.Split(';');
            Produto produto = new Produto();
            produto.Nome = values[0].ToString();
            produto.Preco = Double.Parse(values[1].ToString());
            produto.Quant = Int32.Parse(values[2].ToString());

            return produto;
        }
    }
}
