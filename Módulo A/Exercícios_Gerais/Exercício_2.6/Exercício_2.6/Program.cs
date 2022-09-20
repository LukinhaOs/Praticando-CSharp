using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor para conferir o Intervalo");
            double dado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if (dado < 0 || dado > 100) {
                Console.WriteLine("Valor fora de Intervalo. Tente novamente!");
            }
            else if (dado <= 25.0) {
                Console.WriteLine("Intervalo [0, 25]");
            }
            else if (dado <= 50) {
                Console.WriteLine("Intervalo [25, 50]");
            }
            else if (dado <= 75) {
                Console.WriteLine("Intervalo [50, 75]");
            }
            else {
                Console.WriteLine("Intervalo [75, 100]");
            }
        }
        
    }
}
