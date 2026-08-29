using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.Week4.Day1.Accounts
{
    public class AccountTest
    {
        static void Main(string[] args)
        {

            BankAccount[] Users =
            {
                new BankAccount(1,"Aziz",1200),
                new CurrentAccount(2, "Nick", 1100, 30),
                new SavingsAccount(3, "Nicole", 1300, 20)
            };


            foreach (var user in Users)
            {
                Console.Write($"{user.DisplayEmployeeDetails()}\n");


            }





            Console.WriteLine("Single Data");



            BankAccount user1 = new BankAccount(4, "Ash", 500);
            user1.Deposit(200);
            Console.WriteLine(user1.DisplayEmployeeDetails());

            Console.WriteLine();
            SavingsAccount user2 = new SavingsAccount(5, "Tod", 2000, 55);
            Console.WriteLine(user2.DisplayEmployeeDetails()) ;
            Console.WriteLine(user2.CalculateInterest());


            Console.WriteLine();
            CurrentAccount user3 = new CurrentAccount(6, "Ash", 500, 22);
            user3.Withdraw(200);
            Console.WriteLine(user3.DisplayEmployeeDetails());





            Console.ReadKey();
        }
    }
}
