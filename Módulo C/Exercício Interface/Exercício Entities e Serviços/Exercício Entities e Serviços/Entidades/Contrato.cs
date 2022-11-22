using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_Entities_e_Serviços.Entidades
{
    class Contrato
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }
        public List<Parcelas> Parcelas { get; set; }

        public Contrato(int numero, DateTime dataContrato, double valorTotal)
        {
            Numero = numero;
            Data = dataContrato;
            ValorTotal = valorTotal;
            Parcelas = new List<Parcelas>();
        }

        public void AddParcelas(Parcelas parcelas)
        {
            Parcelas.Add(parcelas);
        }

    }
}
