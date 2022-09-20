using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_CO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo miniretan;

            miniretan = new Retangulo();

            Console.WriteLine("Confira as medidas do retângulo informado os valores; ");
            Console.Write("Altura do retângulo: ");
            miniretan.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Agora informe a largura do retângulo: ");
            miniretan.L = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaRetan = miniretan.Area();
            double periRetan = miniretan.Perimetro();
            double diagRetan = miniretan.Diagonal();

            Console.WriteLine("RESULTADO");

            Console.Write("A área do retângulo possui um valor de " + areaRetan.ToString(CultureInfo.InvariantCulture) + "m²");
            Console.WriteLine();
            Console.Write("O perímetro do retângulo possui um valor de " + periRetan.ToString(CultureInfo.InvariantCulture ) + "m²");
            Console.WriteLine();
            Console.Write("A diagonal do retângulo possui um valor de " + diagRetan.ToString(CultureInfo.InvariantCulture) + "m2");
            Console.WriteLine();
        }
    }
}
