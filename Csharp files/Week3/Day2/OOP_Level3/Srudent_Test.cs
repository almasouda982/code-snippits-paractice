using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.Week3.Day2.OOP_Level3
{
    internal class Srudent_Test
    {
        static void Main(string[] args)
        {

            Student s1 = new Student("Aziz", 35, 50 );
            s1.Set_Mark(50);
            double percentage = s1.Compute_Pct();
            string grade = s1.Grade(percentage);


            Console.Write($"Student's name is {s1.Name}" +
                $"\nStudent's mark is {s1.Get_Mark()}" +
                $"\nStudent's full grade is {s1.Get_FullMark()}" +
                $"\nThe Student's percentage is {percentage}" +
                $"\nThe Student's Grade is a {grade}");


            Console.ReadKey();
        }

    }
}


// Task

/*
 * BMI 
 * with encapsulationn Class name Patient and Patient test
 * Fields Patient name,  weight,  height
 * encapsulate them
 * Get_BMI, Get_Status
 * 
 * 
 */