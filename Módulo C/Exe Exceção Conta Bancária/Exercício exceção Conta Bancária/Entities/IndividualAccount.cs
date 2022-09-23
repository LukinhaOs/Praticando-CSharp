using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Exercício_exceção_Conta_Bancária.Entities.Exceptions;

namespace Exercício_exceção_Conta_Bancária.Entities
{
    class IndividualAccount
    {
        public int NumberAccount { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public IndividualAccount()
        {

        }

        public IndividualAccount(int numberc, string holder, double balance, double withwadraw)
        {
            NumberAccount = numberc;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withwadraw;
        }


        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DominanceException("This operation can't be finish because withdraw exceeds withdraw limit.");
            }

            if (amount > Balance)
            {
                throw new DominanceException("Failed. Doesn't have enough Balance in your account for withdraw.");
            }

            Balance -= amount;
        }
        public override string ToString()
        {
            return "Account Number: "
                + NumberAccount
                + "| "
                + "Holder Account: "
                + Holder
                + "| "
                + "Balance $"
                + Balance.ToString("F2", CultureInfo.InvariantCulture)
                + "| "
                + "WithDrawLimiti $"
                + WithdrawLimit.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
