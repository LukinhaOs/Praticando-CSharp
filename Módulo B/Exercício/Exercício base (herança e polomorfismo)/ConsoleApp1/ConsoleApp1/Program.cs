using System;
using System.Collections.Generic;
using ConsoleApp1.Entities;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> list = new List<Employee>();

            Console.Write("Enter number of employees: ");
            int number = int.Parse(Console.ReadLine());

            for (int itens = 1; itens <= number; itens++)
            {
                Console.WriteLine($"Employee {itens}° data: ");
                Console.Write("Do you want to add Outsourced Employee? [Y]Yes [N]No: ");
                char question = char.Parse(Console.ReadLine());
                Console.Write("Name employee: ");
                string name = Console.ReadLine();
                Console.Write($"Hours worked for {name}: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueperHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (question == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double addtionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valueperHour, addtionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valueperHour));
                }

                Console.WriteLine();
            }
            Console.WriteLine(" ---- PAYMENTS ---- ");
            foreach (Employee p in list)
            {
                Console.WriteLine($"{p.Name} - R${p.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
