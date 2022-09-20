using System;

namespace Membros_estáticos_parte_2
{
    class Calculadora
    {

        // AO REMOVER MEMBROS ESTÁTICOS NÃO SERÁ POSSÍVEL DE EXECUTAR UMA DETERMINADA FUNÇÃO CRIADA SEM QUE VOCÊ A INSTANCIE.
        // Ex: calc.Circunferência ---- O Calc é uma instaciação da Classe "Calculadora"

        public static double Pi = 3.14;
        public static double Circuferencia(double r)
        {
            return 2.0 * Pi * r;

        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }

    }
}
