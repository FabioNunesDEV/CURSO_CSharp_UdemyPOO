using System;
using System.Globalization;

namespace Identitie
{
    class Produto : IComparable<Produto>  
    {
        public string  Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public int CompareTo(Produto other)
        {
            return this.Nome.CompareTo(other.Nome);            
        }

        public override string ToString()
        {
            return $"Nome: {this.Nome}, Preço: {this.Preco.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
