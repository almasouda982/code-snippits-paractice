using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.Week4.Day1.Emps
{
    public class EmployeeHour
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

        public int Hour { get; set; }
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

        public EmployeeHour(string name, int age, double salary, int hours, int hourlyRate)
        {
            Name = name;
            Age = age;
            Salary = salary;
            HourlyRate = hourlyRate;

        }


        //public List<object> DisplayEmployeeDetails()
        //{
        //    List<object> DisplayEmp = new List<object>();
        //    DisplayEmp.Add(Name);
        //    DisplayEmp.Add(Age);
        //    DisplayEmp.Add(Salary);
        //    DisplayEmp.Add(Hour);
        //    DisplayEmp.Add(HourlyRate);

        //    return DisplayEmp;

        //}

        public string DisplayEmployeeDetails()
        {
            return $"Name {Name}, Age: {Age}, Salary: {Salary}, Hours {Hour}, Hourlyrate {HourlyRate}";
        }

        public double CalculateSalary()
        {
            double annual = _salary * 12;

            return annual;

        }

    }
}
