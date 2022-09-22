using System;
using Exe_poliformismo_e_herança.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace Exe_poliformismo_e_herança
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> finalProduct = new List<Product>();

            Console.WriteLine(" ----- WELCOME TO THE LOG PRODUCTS ----- ");
            Console.Write("Enter number of products that you sing up: ");
            int products = int.Parse(Console.ReadLine());

            for(int itens = 1; itens <= products; itens++)
            {
                Console.WriteLine("Do you want, Common Product, Used or Imported? (C/U/I): ");
                char quiz = char.Parse(Console.ReadLine());
                Console.Write($"Enter name of {itens}° product: ");
                string name = Console.ReadLine();
                Console.Write($"Enter {name} price $");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (quiz == 'I')
                {
                    Console.Write("Enter Customs fee: $");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    finalProduct.Add(new ImportedProduct(name, price, fee));
                }
                else if (quiz == 'U')
                {
                    Console.Write("Enter Manufacture Date (dd/MM/yyyy): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    finalProduct.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    finalProduct.Add(new Product(name, price));
                }
                foreach(Product log in finalProduct)
                {
                    Console.WriteLine();
                    Console.WriteLine("----- Product Added! -----");
                    Console.WriteLine($"Product: {log.Name} ${log.Price.ToString("F2", CultureInfo.InvariantCulture)}");
                    Console.WriteLine();

                }
            }

            Console.WriteLine();
            Console.WriteLine("----- LOG OF PRICES -----");
            foreach (Product product in finalProduct)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
