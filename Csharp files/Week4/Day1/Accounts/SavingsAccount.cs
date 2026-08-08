using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.Week4.Day1.Accounts
{
    public class SavingsAccount : BankAccount
    {

        private double _interestRate;
        public double InterestRate {

            get
            {
                return _interestRate;
            }
            set
            {
                if (value >= 0)
                {
                    _interestRate = value;
                }
                else
                {
                    Console.WriteLine("interest Cannot be negative...");
                }
            }


        }




        public SavingsAccount(int accountNumber, string ownerName, double balance, double interestRate) : base(accountNumber, ownerName, balance)
        {
            InterestRate = interestRate;
            
        }


        public double CalculateInterest()
        {

            return InterestRate = Balance * InterestRate / 100;

        }


    }
}
