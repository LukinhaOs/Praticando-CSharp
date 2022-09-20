using System;

namespace Operação_com_DateTK
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2020, 09, 15, 13, 5, 58, DateTimeKind.Local);

            DateTime d2 = new DateTime(2022, 10, 22, 17, 6, 10, DateTimeKind.Utc);

            DateTime d3 = new DateTime(2010, 08, 25, 18, 10, 5);

            Console.WriteLine($"D1: {d1}");
            Console.WriteLine($"D1 KIND: {d1.Kind}");
            Console.WriteLine($"D1 TO LOCAL: {d1.ToLocalTime()}");
            Console.WriteLine($"D1 TO UTC: {d1.ToUniversalTime()}");
            Console.WriteLine();

            Console.WriteLine($"D2: {d2}");
            Console.WriteLine($"D2 KIND: {d2.Kind}");
            Console.WriteLine($"D2 TO LOCAL: {d2.ToLocalTime()}");
            Console.WriteLine($"D2 TO UTC: {d2.ToUniversalTime()}");
            Console.WriteLine();

            Console.WriteLine($"D3: {d3}");
            Console.WriteLine($"D3 KIND: {d3.Kind}");
            Console.WriteLine($"D3 TO LOCAL: {d3.ToLocalTime()}");
            Console.WriteLine($"D3 TO UTC: {d3.ToUniversalTime()}");
            Console.WriteLine();

            // Padrão IOS 8601

            DateTime t1 = DateTime.Parse("2000-08-15 13:05:60");

            DateTime t2 = DateTime.Parse("2020-09-1415T13:05:58Z");

            Console.WriteLine(t1);
            Console.WriteLine(t2);
        }
    }
}
