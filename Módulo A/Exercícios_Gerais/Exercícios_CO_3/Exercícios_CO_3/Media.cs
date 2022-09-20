using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_CO_3
{
    class Media
    {
        public double A1, A2, A3, md1, md2, nr1, nr2;


        public double AF1()
        {
            double s1 = (A1 + A2 + A3) / 3;
            return s1;
        }

        public double AF2()
        {
            double s2 = (A1 + A2 + A3) / 3.5;
            return s2;
        }
        

        public bool Aprovado1()
        {
            if (AF1() >= 6.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Aprovado2()
        {
            if (AF2() >= 6.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotarestanteAF1()
        {
            if (Aprovado1())
            {
                return 0.0;
            }

            else
            {
                return 6.0 - AF1();
            }
        }

        public double NotarestanteAF2()
        {
            if (Aprovado2())
            {
                return 0.0;
            }
            else
            {
                return 6.0 - AF2(); 
            }
        }

    }
}
