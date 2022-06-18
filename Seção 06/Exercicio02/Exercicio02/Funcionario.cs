using System;
using System.Globalization;

namespace Exercicio02
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Double Salary { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Name} , $ {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
