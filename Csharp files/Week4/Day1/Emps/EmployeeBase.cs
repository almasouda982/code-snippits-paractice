using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.Week4.Day1.Emps
{
    public  class EmployeeBase
    {
        public string Name { get; set; }
        private int _age;
        public int Age
        {

            get
            {
                return _age;
            }
            set
            {

                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Age Cannot be 0 or negative");
                }

            }

        }
        private double _salary;
        public double Salary
        {

            get
            {
                return _salary;
            }
            set
            {
                if (value >= 0)
                {
                    _salary = value;
                }
                else
                {
                    Console.WriteLine("salary Cannot be negative");
                }
            }


        }
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

        public EmployeeBase(string name, int age, double salary, double bonus)
        {
            Name = name;
            Age = age;
            Salary = salary;
            Bonus = bonus;
            
        }


        //public List<object> DisplayEmployeeDetails()
        //{
        //    List<object> DisplayEmp = new List<object>();
        //    DisplayEmp.Add(Name);
        //    DisplayEmp.Add(Age);
        //    DisplayEmp.Add(Salary);
        //    DisplayEmp.Add(Bonus);

        //    return DisplayEmp;

        //}

        //public double CalculateSalary()
        //{
        //    double salary = Salary * 12;

        //    return salary;

        //}



        public string DisplayEmployeeDetails()
        {
            return $"Name {Name}, Age: {Age}, Salary: {Salary}, Bonus {Bonus}";
        }

        public double CalculateSalary()
        {
            double annual = _salary * 12;

            return annual;

        }




    }
}
