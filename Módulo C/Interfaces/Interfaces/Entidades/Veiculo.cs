using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Entidades
{
    class Veiculo
    {
        public string Modelo { get; set; }

        public Veiculo (string modelo)
        {
            Modelo = modelo;
        }
    }
}
