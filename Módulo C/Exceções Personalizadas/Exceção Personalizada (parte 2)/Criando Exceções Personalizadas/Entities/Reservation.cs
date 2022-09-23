using System;


namespace Criando_Exceções_Personalizadas.Entities
{
    class Reservation
    {
        public int Number { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public string UpdateReservation(DateTime checkin, DateTime checkout) {
            if (checkin < now || checkout < now)
            {
                return "Reservation error. The date of reservation for uptade must be future.";
            }

            if (checkout <= checkin)
            {
                ("Reservation error. The date of reservation for uptade must be future dates.";
            }

            CheckIn = checkin;
            CheckOut = checkout;
        }

        public Reservation(int number, DateTime checkIn, DateTime checkOut)
        {
            Number = number;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public override string ToString()
        {
            return "Room: " + Number
                + ", Check In: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", CheckOut: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " Nights: ";
        }
    }
}
