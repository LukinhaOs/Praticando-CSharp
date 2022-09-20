using System;
using System.Globalization;

namespace Exercícios_Membros_estáticos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe o valor a ser comprado em Dollar U$");
            double real = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Agora informe a cotação atual. Ex: R$5.19");
            ConversorMoeda.valorcota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double convertido = ConversorMoeda.Dollar(real);

            Console.WriteLine($"Obs: IOF atual é 0.38% e cotação informada {ConversorMoeda.valorcota.ToString(CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor convertido de Dollar para Real. | U${real.ToString("F2", CultureInfo.InvariantCulture)} + IOF 0.38% para R${convertido.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}