using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class PrintService<T>
    {
        private T[] _valores = new T[10];
        private int _contador = 0;

        public void AddValor (T valor)
        {
            if (_contador > 10)
            {
                throw new InvalidOperationException("Limite máximo de itens atingido.");
            }
            _valores[_contador] = valor;
            _contador++;
        }

        public T First()
        {
            if (_contador == 10)
            {
                throw new InvalidOperationException("Ainda não existe dados.");
            }

            return _valores[0];
        }

        public void Print()
        {
            Console.Write("[ ");
            for (int i = 0; i < _contador-1; i++)
            {
                Console.Write(_valores[i] + ", ");                
            }
            Console.WriteLine(_valores[_contador - 1] + " ]");
        }
    }
}
