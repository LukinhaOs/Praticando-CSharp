using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_Lambda_Linq.Entidades
{
    class Empregado
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public double Salario { get; set; }

        public Empregado(string nome, string email, double salario)
        {
            Nome = nome;
            Email = email;
            Salario = salario;
        }
    }
}
