using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercício_fixação_Lista
{
    class Funcionario
    {
        public string Nome;
        public int IDEmpregrado;
        public double Salario;

        public Funcionario(string nome, int id, double salario)
        {
            Nome = nome;
            IDEmpregrado = id;
            Salario = salario;
        }

        public void AumentoSalarial (double porcentagem)
        {
            Salario = Salario + (Salario / 100 * porcentagem);
        }

        public override string ToString()
        {
            return "Nome do funcionário "
                + Nome + " | ID do funcionário "
                + IDEmpregrado + " | Salario R$"
                + Salario.ToString(CultureInfo.InvariantCulture);
        }
    }
}
