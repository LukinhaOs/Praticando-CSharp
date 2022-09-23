using System;
using Tratativa_de_exceção.Entities;
using Tratativa_de_exceção.Entities.Exceptions;

namespace Tratativa_de_exceção
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine($"Welcome {name}!");
                Console.Write("Now, enter your Room Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write($"{name}. It's important enter Check In (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Now Check Out (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine($"Your Reservation is registered! {reservation}");

                Console.WriteLine();
                Console.Write("Enter your reservation atualization (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Enter your Check-Out atualization (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Dates uptades!");
                reservation.UptadeDateTime(checkin, checkout);
                Console.WriteLine($"New Reservation: {reservation}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("You have to enter only number of room. " + e.Message);
            }
            catch(DominainExecption fail)
            {
                Console.WriteLine("Error of your reservation: " + fail.Message);
            }
            catch(Exception a)
            {
                Console.WriteLine("Unknowm error. Please, try again." + a.Message);
            }
        }
    }
}
