using System;
using System.Collections.Generic;
using System.Text;
using Tratativa_de_exceção.Entities.Exceptions;

namespace Tratativa_de_exceção.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public double DurartionNights()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public double DurationHours()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalHours;
        }

        public void UptadeDateTime(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DominainExecption ("Date error! You have enter recents dates for reservation! Might be future dates.");
            }
            else if (CheckOut <= CheckIn)
            {
                throw new DominainExecption ("Date Check-Out error! You have to enter after dates of Check-In for reservation! Might be future dates.");

            }
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room Number: "
                + ", Check-In: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", Check-Out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", Totally hours: "
                + DurationHours()
                + " hours"
                + ", Totally nights: "
                + DurartionNights()
                +" nights.";
        }
    }
}
