using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.Week4.Day1.Accounts
{
    public class CurrentAccount : BankAccount
    {
        public double OverDraftLimit { get; set; }

        public CurrentAccount(int accountNumber, string ownerName, double balance, double overDraftLimit) : base(accountNumber, ownerName, balance)
        {
            OverDraftLimit = overDraftLimit;
        }


        public double Withdraw(double amount)
        {
            if (Balance <= 0)
            {
                Console.WriteLine("Cannot Withdraw the balance is negative ");
            }
            else
            {
                Balance = Balance - amount;

            }
            return Balance;
        }

    }
}
