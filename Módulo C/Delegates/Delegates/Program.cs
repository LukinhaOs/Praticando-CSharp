using System;
using Delegates.Serviços;

namespace Delegates
{
    class Program
    {
        delegate void BinaryNumericOperation(double x, double y); 
        
        // Com o "void" é possível de criar multicast delegates...
        // Sem o void utilize static double, int, etc...
        
        static void Main(string[] args)
        {
            Console.Write("Informe o primeiro valor: ");
            double a1 = double.Parse(Console.ReadLine());
            Console.Write("Muito bem! Agora informe o segundo valor: ");
            double a2 = double.Parse(Console.ReadLine());

            BinaryNumericOperation verificar = CalculoServico.ShowSoma;
            verificar += CalculoServico.ShowMax;

            verificar.Invoke(a1, a2);
        }
    }
}
