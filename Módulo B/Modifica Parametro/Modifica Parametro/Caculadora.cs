using System;
using System.Collections.Generic;
using System.Text;

namespace Modifica_Parametro
{
    class Caculadora
    {
        // Params é um método para informar ao compilador que o usuário deseja quantia variável de valores
        public static int Soma(params int[] numeros)
        {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }
            return soma;
        }
    }
}