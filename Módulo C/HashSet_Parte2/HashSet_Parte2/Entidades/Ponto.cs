using System;
using System.Collections.Generic;
using System.Text;

namespace HashSet_Parte2.Entidades
{
    struct Ponto
    {
        //Essa classe por padrão implementa os procedimentos GetHashCode e Equals
        public int X { get; set; }
        public int Y { get; set; }

        public Ponto (int x, int y) : this()
        {
            X = x;
            Y = y;
        }
    }
}
