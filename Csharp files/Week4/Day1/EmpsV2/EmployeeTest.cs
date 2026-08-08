using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.Week4.Day1.EmpsV2
{
    internal class EmployeeTest
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Aziz", 28, 2500);
            EmployeeBase employee2 = new EmployeeBase("Kyle", 26, 2100, 120);
            EmployeeHour employee3 = new EmployeeHour("Nicole", 25, 10000,12, 160);


            Employee[] employees =
            {
                new Employee("Aziz", 28, 2500),
                new EmployeeBase("Kyle", 26, 2100, 120),
                new EmployeeHour("Nicole", 25, 10000,12, 160)
            };


            foreach (var emp in employees)
            {
                Console.Write($"{emp.DisplayEmployeeDetails()}, Annual {emp.CalculateSalary()}\n");
            }

            Console.ReadKey();
        }
    }
}
