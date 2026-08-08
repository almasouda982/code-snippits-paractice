using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstConsoleApp.Week4.Day1.EmpsV2
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private double _salary;
        public double Salary {

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


        public Employee(string name, int age, double salary)
        {

            Name = name;
            Age = age;
            Salary = salary;

        }

        //public List<object> DisplayEmployeeDetails()
        //{
        //    List<object> DisplayEmp = new List<object>();
        //    DisplayEmp.Add(Name);
        //    DisplayEmp.Add(Age);
        //    DisplayEmp.Add(Salary);

        //    return DisplayEmp;


        //}

        //public double CalculateSalary()
        //{
        //    double salary = Salary * 12;

        //    return salary;

        //}

        public string DisplayEmployeeDetails()
        {
            return $"Name {Name}, Age: {Age}, Salary: {Salary}";
        }

        public double CalculateSalary()
        {
            double annual = _salary * 12;

            return annual;

        }




    }
}
