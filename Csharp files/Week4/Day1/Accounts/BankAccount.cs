using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstConsoleApp.Week4.Day1.Accounts
{
    public class BankAccount
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


        public string DisplayEmployeeDetails()
        {
            return $"Account Number {AccountNumber}, Owner Name: {OwnerName}, Balance: {Balance}";
        }

        public double Deposit(double amount)
        {



            if (amount < 0)
            {
                Console.WriteLine("Cannot Deposit negative values");
            }
            else
            {
               Balance = amount + Balance; ;

            }
            return Balance;
        }


    }
}
