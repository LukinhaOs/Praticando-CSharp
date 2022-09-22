using System;
using System.Collections.Generic;
using System.Text;

namespace Modificador_ref
{
    class Calculator
    {
        public static void Triplo(ref int x)
        {
            x = x * 3;
        }

        public static void TriploTipo2(int origem, out int resultado)
        {
            resultado = origem * 3;
        }
    }
}
