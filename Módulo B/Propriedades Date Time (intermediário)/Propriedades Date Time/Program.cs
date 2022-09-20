using System;

namespace Propriedades_Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2000, 8, 15, 13, 45, 58, 275);

            string s1 = d.ToLongTimeString();
            string s2 = d.ToShortDateString();
            string s3 = d.ToShortTimeString();

            string s5 = d.ToString("yyyy-MM-dd HH:mm:ss");

            Console.WriteLine(d.ToLongDateString());
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s5);

            DateTime d2 = d.AddHours(2);
            DateTime d3 = d.AddMinutes(3);
            
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            DateTime dia1 = new DateTime(2022, 08, 15);

            DateTime dia2 = new DateTime(2022, 08, 20);

            TimeSpan menos = dia2.Subtract(dia1);

            Console.WriteLine($"A diferença entre o 'dia1' e 'dia2' é {menos}");

        }
    }
}
