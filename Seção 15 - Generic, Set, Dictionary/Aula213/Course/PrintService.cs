using System;

namespace Course
{
    class PrintService
    {
        private int[] _valores = new int[10];
        private int _contador = 0;

        public void AddValor (int valor)
        {
            if (_contador > 10)
            {
                throw new InvalidOperationException($"Número maxímo de itens (10), atingido");
            }

            _valores[_contador] = valor;
            _contador++;
        }

        public int First()
        {
            if (_contador == 0)
            {
                throw new InvalidOperationException($"Não existe dados.");
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

            Console.Write(_valores[_contador-1] + " ]");
            Console.WriteLine();

        }
    }
}
