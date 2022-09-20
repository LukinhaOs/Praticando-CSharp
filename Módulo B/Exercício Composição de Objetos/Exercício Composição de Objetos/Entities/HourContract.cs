using System;

namespace Exercício_Composição_de_Objetos.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hour {get; set;}

        public HourContract()
        {

        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hour = hours;
        }

        public double TotalValue()
        {
            return Hour * ValuePerHour;
        }
    }
}
