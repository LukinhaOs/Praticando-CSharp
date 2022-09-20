using System;

namespace Exercícios_CO_1
{
    class Retangulo
    {
        public double A;
        public double L;

        public double Area ()
        {
            double a = A * L;
            return a;
        }

        public double Perimetro ()
        {
            double p = (A + L) * 2;
            return p;
        }

        public double Diagonal ()
        {
            return Math.Sqrt((Math.Pow(A, 2) + (Math.Pow(L, 2))));
        }
    }
}
