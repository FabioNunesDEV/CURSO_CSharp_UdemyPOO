using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Aluno
    {
        public string Nome;
        public double Trim1;
        public double Trim2;
        public double Trim3;

        double Corte = 60.0;
        
        public double NotaFinal()
        {
            return Trim1 + Trim2 + Trim3;
        }

        public string Status()
        {
            string retorno = "";
            if (NotaFinal() < Corte)
            {
                retorno = "REPROVADO";
            }
            else
            {
                retorno = "APROVADO";
            }

            return retorno;
        }

        public double Falta()
        {
            return Corte - NotaFinal();
        }

    }
}
