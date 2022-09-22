using System;

namespace Durações_com_Timespan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            TimeSpan t2 = new TimeSpan();
            TimeSpan t3 = new TimeSpan(900000000L);
            TimeSpan t4 = new TimeSpan(5, 7, 12, 30, 321);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine();

            TimeSpan from1 = TimeSpan.FromDays(1.5);
            TimeSpan from2 = TimeSpan.FromHours(1.5);
            TimeSpan from3 = TimeSpan.FromMinutes(1.5);
            TimeSpan from4 = TimeSpan.FromSeconds(1.5);
            TimeSpan from5 = TimeSpan.FromMilliseconds(1);
            TimeSpan from6 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(from1);
            Console.WriteLine(from2);
            Console.WriteLine(from3);
            Console.WriteLine(from4);
            Console.WriteLine(from5);
            Console.WriteLine(from6); 
        }
    }
}
