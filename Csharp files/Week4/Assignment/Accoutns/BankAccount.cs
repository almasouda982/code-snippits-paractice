using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp1.Week4.Assignment.Accoutns
{
    public abstract class BankAccount : IAccount
    {
        public int AccountNumber { get; set; }
        public string OwnerName { get; set; }
        public double Balance { get; set; }


        public BankAccount(int accountNumber, string ownerName, double balance)
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            Balance = balance;
        }

        public virtual string DisplayAccount()
        {
            return $"Account Number: {AccountNumber}, Owner Name: {OwnerName}, Balance: {Balance}";
        }

        //public void Deposit(double amount)
        //{
        //    if (amount > 0)
        //    {
        //        Balance += amount;
        //        Console.WriteLine($"Deposited: {amount}. New Balance: {Balance}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Deposit amount must be positive.");
        //    }
        //}
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: {amount}. New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }


    }
}
