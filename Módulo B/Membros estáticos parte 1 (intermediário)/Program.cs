using System;
using System.Globalization;

namespace Membros_estáticos_parte_1
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.Write("Digite um valor para o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double cir = Circuferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferencia: " + cir.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de Pi: {Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        static double Circuferencia(double r)
        {
            return 2.0 * Pi * r;

        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }

        }
    }
