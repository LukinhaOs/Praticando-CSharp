using System;
using System.Collections.Generic;
using Exe_final_composição_objeto.Entidades.Enum;

namespace Exe_final_composição_objeto.Entidades
{
    class Trabalhador
    {
        public string Nome { get; set; }
        public LevelWork Nivel_funcionario { get; set; }
        public double SalarioPadrao { get; set; }

        public Departamento Departamento { get; set; }

        List<ContratoHora> Contrato { get; set; } = new List<ContratoHora>();

        public Trabalhador()
        {

        }

        public Trabalhador(string nome, LevelWork nivel_funcionario, Departamento departamento, double salariopadrao)
        {
            Nome = nome;
            Nivel_funcionario = nivel_funcionario;
            SalarioPadrao = salariopadrao;
            Departamento = departamento;
        }

        public void AddContrato(ContratoHora hora)
        {
            Contrato.Add(hora);
        }

        public void RemoveContrato(ContratoHora hora)
        {
            Contrato.Remove(hora);
        }

        public double GanhoSalario(int ano, int mes)
        {
            double soma = SalarioPadrao;
            foreach (ContratoHora contratofinal in Contrato)
            {
                if (contratofinal.Data.Year == ano && contratofinal.Data.Month == mes)
                {
                    soma += contratofinal.Valortotal();
                }
            }
            return soma;
        }
    }
}
