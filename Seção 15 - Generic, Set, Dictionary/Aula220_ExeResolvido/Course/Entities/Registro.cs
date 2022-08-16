using System;

namespace Entities
{
    class Registro
    {
        public string Nome { get; set; }
        public DateTime Instante { get; set; }

        public Registro(string nome, DateTime instante)
        {
            Nome = nome;
            Instante = instante;
        }

        public override int GetHashCode()
        {
            return Nome.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj is not Registro)
            {
                throw new ArgumentException("Não é um objeto Registro");
            }

            Registro outro = obj as Registro;

            return Nome.Equals(outro.Nome);
        }
    }
}
