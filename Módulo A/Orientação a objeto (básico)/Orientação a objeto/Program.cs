using System;
using System.Globalization;

namespace Orientação_a_objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            // ESSE PROGRAMA CONTEM PRÁTICAS COM CLASSE DE OBJETOS!
            // EM VERSÃO ANTERIOR FOI REALIZADO PRÁTICA SEM OBJETOS!

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Informe as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine("Área do triângulo X: " + areaX.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("Área do triângulo Y: " + areaY.ToString(CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("O triângulo de maior área é o X");
            }
            else
            {
                Console.WriteLine("O triângulo de maior área é o  Y");
            }
        }
    }
}
