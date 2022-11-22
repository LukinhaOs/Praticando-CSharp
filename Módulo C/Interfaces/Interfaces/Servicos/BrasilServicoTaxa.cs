using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Servicos
{
    class BrasilServicoTaxa : ITaxaServicos
    {
        public double Taxa(double quantia)
        {
            if (quantia <= 100.0)
            {
                return quantia * 0.20;
            }
            else
            {
                return quantia * 0.15;
            }
        }
    }
}
