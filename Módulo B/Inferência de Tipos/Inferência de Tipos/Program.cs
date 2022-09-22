using System;

namespace Inferência_de_Tipos
{
    class Program
    {
        static void Main(string[] args)
        {
            // "Var" é uma inferência de tipos de dados, logo não precisa declarar (supostamente)

            var x = 10; // O var converte o dado para inteiro, logo acima para os demais abaixo com seus tipos de dados.
            var y = 20.0;
            var z = "Maria";
        }
    }
}
