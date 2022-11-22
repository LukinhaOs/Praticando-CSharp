using System;
using System.Collections.Generic;
using System.Text;
using Interfaces.Entidades;

namespace Interfaces.Servicos
{
    class ServicoAluguel
    {
        public double PrecoHora { get; set; }
        public double PrecoDia { get; set; }

        private ITaxaServicos _brazilServicoTaxa;
        public ServicoAluguel(double precoHora, double precoDia, ITaxaServicos taxaServico)
        {
            PrecoHora = precoHora;
            _brazilServicoTaxa = taxaServico;
            PrecoDia = precoDia;
        }

        public void ProcessoFatura(AluguelCarro aluguelCarro)
        {
            TimeSpan duracao = aluguelCarro.Finalizacao.Subtract(aluguelCarro.Inicio);

            double pagamentoBase = 0.0;
            if (duracao.TotalHours <= 12.0)
            {
                pagamentoBase = PrecoHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                pagamentoBase = PrecoDia * Math.Ceiling(duracao.TotalDays);
            }

            double taxa = _brazilServicoTaxa.Taxa(pagamentoBase);

            aluguelCarro.Custo = new Custo(pagamentoBase, taxa);
        }
    }
}