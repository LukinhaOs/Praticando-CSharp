using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_CO_2
{
    class Salario
    {

        public double imposto = 1000.00;
        public double salarioatual;
        public int porcentagem;

        public double aumento()
        {
            double s = salarioatual + (salarioatual * porcentagem / 100.0);
            return s;
        }
    }
}
