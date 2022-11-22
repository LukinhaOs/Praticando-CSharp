using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Entidades
{
    class AluguelCarro
    {
        public DateTime Inicio { get; set; }
        public DateTime Finalizacao { get; set; }
        public Veiculo Veiculo { get; set; }
        public Custo Custo { get; set; }

        public AluguelCarro(DateTime inicio, DateTime finalizacao, Veiculo veiculo)
        {
            Inicio = inicio;
            Finalizacao = finalizacao;
            Veiculo = veiculo;
            Custo = null;
        }
    }
}
