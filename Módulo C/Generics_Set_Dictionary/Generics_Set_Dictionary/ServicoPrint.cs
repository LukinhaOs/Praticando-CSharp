using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Set_Dictionary
{
    class ServicoPrint<T>
    {
        // Não usar tipo "OBJECT" nesse programa. Um valor do tipo object é bom para reuso mas é problema para typeSafe e performace...

        private T[] _valores = new T[10]; // Não usar tipo "OBJECT"
        private int _contador = 0;

        public void addValor(T value)
        {
            if (_contador == 10)
            {
                throw new InvalidOperationException("O PrintServico está cheio, não é possível de adicionar mais valores");
            }
            _valores[_contador] = value;
            _contador++;
        }

        public T PrimeiroValor()
        {
            if (_contador == 0)
            {
                throw new InvalidOperationException("O PrintServico está vazio. Não é possível de adicionar o número 0");
            }
            return _valores[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _contador -1; i++)
            {
                Console.Write(_valores[i] + " ,");
            }
            if (_contador > 0)
            {
                Console.Write(_valores[_contador - 1]);
            }
            Console.WriteLine("]");
        }
    }
}
