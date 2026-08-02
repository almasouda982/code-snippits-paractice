using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.Week3.Day1.Return_Functions
{
    internal class Methods
    {
        //public void Sum2(int num1, int num2)
        //{
        //    int res = num1 + num2;
        //    Console.WriteLine(res);
        //}

        //public int Sum3(int num1, int num2)
        //{
        //    int res = num1 + num2;
        //    return (res);
        //}


        //public void Compute_Sal2(string name, double salary, double bonus)
        //{
        //    double totalSalary = salary + bonus;
        //    double annualSalary = totalSalary * 12;

        //    Console.WriteLine("Employee Name: " + name);
        //    Console.WriteLine("Salary: " + salary);
        //    Console.WriteLine("Bonus: " + bonus);
        //    Console.WriteLine("Total Salary: " + totalSalary);
        //    Console.WriteLine("Annual Salary: " + annualSalary);
        //}

        //public double Compute_Sal3(string name, double salary, double bonus)
        //{
        //    double totalSalary = salary + bonus;
        //    double annualSalary = totalSalary * 12;

        //    return (annualSalary);

        //}

        //-------------------void method type------------------
        public void Compute_Pct2(string name, double mark, double fullMark)
        {



            double percentage = (mark / fullMark) * 100;
            Console.Write($" Student Name:  {name} \nyour  mark is: {mark} \nYour Percentage is:{percentage} %");
        }


        //------------------return method type---------------- 

        public double Compute_Pct3(string fullname, double mark, double fullMark)
        {

            double percentage = (mark / fullMark) * 100;
            return percentage;
            //Console.Write($" Student Name:  {name} \nyour  mark is: {mark} \nYour Percentage is:{percentage} %");
        }





        //-------------------void method type------------------


        public void Compute_BMI2(string name, double weight, double height)
        {

            double BMI = weight / Math.Pow((height / 100), 2);


            Console.WriteLine($"Patient Name: {name} ");
            Console.WriteLine($"Patient Weight:{weight} ");
            Console.WriteLine($"Patient Height: {height}");
            Console.WriteLine($"Patient BMI: {BMI} ");

        }


        ////------------------return method type---------------- 
        //public double Compute_BMI3(string name, double weight, double height)
        //{

        //    double BMI = weight / Math.Pow((height / 100), 2);
        //    return BMI;

        //}




        //------------------turn to list return method type---------------- 
        public List<object> Compute_BMI4(string name, double weight, double height)
        {
            List<object> calbmi = new List<object>();
            double BMI = weight / Math.Pow((height / 100), 2);
            calbmi.Add(name);
            calbmi.Add(weight);
            calbmi.Add(height);
            calbmi.Add(BMI);

            
            return calbmi;


        }


        public List<object> Compute_Pct4(string fullname, double mark, double fullMark)
        {
            List<object> calPct = new List<object>();
            double percentage = (mark / fullMark) * 100;
            calPct.Add(fullname);
            calPct.Add(mark);
            calPct.Add(fullMark);
            calPct.Add(percentage);

            return calPct;
        }


    }
}
