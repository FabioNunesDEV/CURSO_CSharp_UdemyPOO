using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;

namespace Entities
{
    class Funcionario:IComparable
    {  
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string textoFuncionario)
        {
            string[] item = textoFuncionario.Split(",");
            this.Nome = item[0];
            this.Salario = double.Parse(item[1],CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return "Nome: " + Nome + " - Salário: " + Salario;
        }


        public int CompareTo(Object obj)
        {
            if (!(obj is Funcionario))
            {
                throw new Exception("O objeto deve ser do tipo Funcionario");
            }

            Funcionario outro = obj as Funcionario;

            return Salario.CompareTo(outro.Salario);
        }
    }
}
