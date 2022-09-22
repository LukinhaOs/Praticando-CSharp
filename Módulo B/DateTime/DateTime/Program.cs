using System;
using System.Globalization;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2022, 09, 14);
            DateTime d2 = new DateTime(2022, 09, 14, 11, 48, 25);
            DateTime d3 = new DateTime(2022, 09, 14, 11, 48, 25, 3);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);

            DateTime dia = DateTime.Parse("2022-09-14 13:05:58");
            Console.WriteLine(dia);

            DateTime MYDAY = DateTime.ParseExact("2000-06-22", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            Console.WriteLine(MYDAY);
        }
    }
}