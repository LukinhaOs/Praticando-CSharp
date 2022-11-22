using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Especifica source

            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Define query expressions
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            // Executa a query
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
