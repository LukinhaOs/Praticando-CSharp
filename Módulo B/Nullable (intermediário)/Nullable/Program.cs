using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Com o "Nuablle" é postivo de dar um valor opcional "Null" para os Structs que são valores. Ex: Data de nascimento, número, etc
            
            double? x = null; // Você pode escrever ' Nuablle<double> '  ou ' double? '.
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue); // Resultado Booleano
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");
            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");
        }
    }
}