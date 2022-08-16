using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override int GetHashCode()
        {
            return Nome.GetHashCode() + Preco.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is not Produto)
            {
                throw new ArgumentException("O objeto não é um produto.");
            }

            Produto outro = obj as Produto;

            return Nome == outro.Nome && Preco == outro.Preco;
        }
    }
}
