using System;
using System.Globalization;
using Exercício_exceção_Conta_Bancária.Entities;
using Exercício_exceção_Conta_Bancária.Entities.Exceptions;

namespace Exercício_exceção_Conta_Bancária
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your number Account: ");
            int numberAccount = int.Parse(Console.ReadLine());
            Console.Write("Every Okay. Enter your name: ");
            string nameAccount = Console.ReadLine();
            Console.Write("Confirm Actual Balance of your Account $");
            double balanceAccount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Confirm your WithdrawLimit for withdraw $");
            double withdrawLAccount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            IndividualAccount person = new IndividualAccount(numberAccount, nameAccount, balanceAccount, withdrawLAccount);

            Console.WriteLine("Do you want to add more amount of money? (Y)YES (N)NO: ");
            char quiz = char.Parse(Console.ReadLine());
            
            if (quiz == 'Y' || quiz == 'y')
            {
                Console.Write("Enter amount for deposit $");
                double amountd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                person.Deposit(amountd);
                Console.WriteLine("Deposit Amount Sucefully!");
            }

            Console.WriteLine();
            Console.Write("Enter amount that you withdraw $");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Balance updated!");
            Console.WriteLine();

            try
            {
                person.Withdraw(amount);
                Console.WriteLine("New Balance: $" + person.Balance.ToString(CultureInfo.InvariantCulture));
                Console.WriteLine();
                Console.WriteLine("------ DETAILS ACCOUNT ------");
                Console.WriteLine(person);
            }
            catch (DominanceException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}
