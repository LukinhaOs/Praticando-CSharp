using System;

namespace Switch_Case
{
    class Progrsam
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número da semana: ");
            int x = int.Parse(Console.ReadLine());
            string dia;

            switch (x)
            {
                case 1:
                    dia = "Domingo";
                    break;
                default:
                    Console.WriteLine("Valor Inválido");
                    break;
            }

            Console.WriteLine($"Dia de hoje: {dia}");

            /*    if (x == 1)
                {
                    dia = "Sunday";
                }
                else if (x == 2)
                {
                    dia = "Monday";
                }
                else if (x == 3)
                {
                    dia = "Tuesday";
                }
                else if (x == 4)
                {
                    dia = "Wednesday";
                }
                else if (x == 5)
                {
                    dia = "Thursday";
                }
                else if (x == 6)
                {
                    dia = "Friday";
                }
                else if (x == 7)
                {
                    dia = "Saturday";
                }
                else
                {
                    Console.WriteLine("Valor inválido.");
                }

            */
            ;
        }
    }
}
