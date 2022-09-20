using System;
using System.Globalization;

namespace Problema_sem_Orientação_a_Objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Informe as medidas do triângulo X: ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Informe as medidas do triângulo Y: ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double area1 = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double area2 = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("A área de X: " + area1.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("A área de Y: " + area2.ToString("F4", CultureInfo.InvariantCulture));

            if (area1 > area2)
            {
                Console.WriteLine("A maior área é do triângulo X");
            }
            else
            {
                Console.WriteLine("A maior área é do triângulo Y");
            }
        }
    }
}
