using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Cliente
    {
        public String Nome { get; set; }
        public String Email { get; set; }

        public Cliente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override bool Equals(object obj)
        {
            if (obj is not Cliente)
            {
                throw new ArgumentException("O parametro não é um objeto Cliente.");
            }

            Cliente outro = obj as Cliente;

            return Email.Equals(outro.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
