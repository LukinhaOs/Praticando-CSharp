using System;
using System.Globalization;

namespace Membros_estáticos_parte_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um valor para o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circuferencia(raio); // Circunferência é uma função  para "Static" e não foi preciso instãncia-lá. Logo use somente "Calculadora.Circunferência"
            double volume = Calculadora.Volume(raio); // Static 

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de Pi: {Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}"); // Static
        }
    }
}
