using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.Week4.Day1.EmpsV2
{
    public  class EmployeeBase : Employee
    {

        private double _bonus;
        public double Bonus {

            get
            {
                return _bonus;
            }
            set
            {
                if (value >= 0)
                {
                    _bonus = value;
                }
                else
                {
                    Console.WriteLine("bonus Cannot be negative");
                }
            }


        }

        public EmployeeBase(string name, int age, double salary, double bonus) : base(name, age, salary)
        {
            Bonus = bonus;
            
        }




    }
}
