using System;
using Contribuinte_Imposto.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace Contribuinte_Imposto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contributor> form = new List<Contributor>();

            Console.Write("Enter number of tax payers: ");
            int payers = int.Parse(Console.ReadLine());

            for (int itens = 1; itens <= payers; itens++)
            {
                Console.Write("Payer is Individual(I) or Company(C)? (I/C): ");
                char quiz = char.Parse(Console.ReadLine());
                if (quiz == 'I')
                {
                    Console.WriteLine($"{itens}° Contributer...");
                    Console.Write("Enter name of contributer: ");
                    string contriName = Console.ReadLine();
                    Console.Write($"How much was Anual Income of {contriName}? $");
                    double earnContributor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Enter Health Expenditures $");
                    double healthSpend = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    form.Add(new Individual(contriName, earnContributor, healthSpend));
                }
                else if (quiz == 'C')
                {
                    Console.Write("Enter name of Company: ");
                    string companyName = Console.ReadLine();
                    Console.Write($"Hoe much was Anual Income of Company {companyName}? $");
                    double earnCompany = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Enter number of employees: ");
                    int employee = int.Parse(Console.ReadLine());
                    form.Add(new Company(companyName, earnCompany, employee));
                }
                else
                {
                    Console.WriteLine("The date informated is wrong. Please, try again!");
                    break;
                }
            }
            Console.WriteLine(" ----- TAXES PAID ----- ");
            double plus = 0.0;

            foreach(Contributor details in form)
            {
                double tax = details.TaxesPaid();
                Console.WriteLine("Name " + details.Name + " Taxes $" + details.TaxesPaid().ToString("F2", CultureInfo.InvariantCulture));
                plus += tax;
            }
            Console.WriteLine();
            Console.WriteLine($"Total Tax of Contributers ${plus.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
