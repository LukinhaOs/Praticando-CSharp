using System;
using System.Collections.Generic;
using System.Text;

namespace Exe_final_composição_objeto.Entidades
{
    class ContratoHora
    {
        public DateTime Data { get; set; }
        public double ValorPorHora { get; set; }
        public int Hora { get; set; }


        public ContratoHora()
        {

        }

        public ContratoHora(DateTime data, double valorPorHora, int hora)
        {
            Data = data;
            ValorPorHora = valorPorHora;
            Hora = hora;
        }

        public double Valortotal()
        {
            return Hora * ValorPorHora;
        }
    }
}
