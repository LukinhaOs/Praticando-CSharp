using System;
using System.Collections.Generic;
using System.Text;

namespace Exercícios_Membros_estáticos
{
    class ConversorMoeda
    {
        public static double valorcota;
        public static double  Dollar(double moeda)
        {
            double iof = moeda * valorcota * 0.0038;
            return moeda * valorcota + iof;
        }
    }
}
