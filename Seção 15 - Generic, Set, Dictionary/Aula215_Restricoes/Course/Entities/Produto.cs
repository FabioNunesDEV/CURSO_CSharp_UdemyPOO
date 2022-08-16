using System;
using System.Globalization;

namespace Entities
{
    class Produto:IComparable
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }

        public override string ToString()
        {
            return Nome + ", " + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if (obj is not Produto)
            {
                throw new ArgumentException("Este parametro não é um objeto Produto.");
            }

            Produto outro = obj as Produto;

            return Preco.CompareTo(outro.Preco);
        }
    }
}
