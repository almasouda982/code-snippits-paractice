using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.Week4.Day1.EmpsV2
{
    public class EmployeeHour : Employee
    {


        public int Hours { get; set; }
        private int _hourlyRate;
        public int HourlyRate
        {

            get
            {
                return _hourlyRate;
            }
            set
            {
                if (value >= 0)
                {
                    _hourlyRate = value;
                }
                else
                {
                    Console.WriteLine("HourlyRate Cannot be negative");
                }
            }


        }

        public EmployeeHour(string name, int age, double salary, int hours, int hourlyRate) : base(name, age, salary)
        {
            Hours = hours;
            HourlyRate = hourlyRate;

        }

    }
}
