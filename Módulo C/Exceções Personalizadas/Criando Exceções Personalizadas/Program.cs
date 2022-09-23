using System;
using Criando_Exceções_Personalizadas.Entities;

namespace Criando_Exceções_Personalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter of your Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Informe your chechIn dare (dd/MM/yyyy): ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());
            Console.Write("Now, your date checkOut (dd/MM/yyyy): ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            if (checkout <= checkin)
            {
                Console.WriteLine("Error in reservation: Check-Out might be after date of Check-In");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine($"Your Reservation: {reservation} ");

                Console.WriteLine();

                Console.Write("Enter of dates to uptade Reservation: ");
                Console.Write("Informe your chechIn dare (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Now, your date checkOut (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;

                if (checkin < now || checkout < now)
                {
                    Console.WriteLine("Reservation error. The date of reservation for uptade must be future.");
                }

                else if (checkout <= checkin)
                {
                    Console.WriteLine("Reservation error. The date of reservation for uptade must be future dates.");
                }
                else
                {
                    reservation.UpdateReservation(checkin, checkout);
                    Console.WriteLine("Uptade Reseration");
                    Console.WriteLine($"Your reservation now: {reservation}");
                     
                }
            }
        }
    }
}
