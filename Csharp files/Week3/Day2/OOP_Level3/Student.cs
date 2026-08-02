using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.Week3.Day2.OOP_Level3
{
    // Name (N)
    public class Student
    {

        // Properties (P)
        public string Name;
        private double Mark;
        private double FullMark;


        public Student(string name, double mark, double fullMark)
        { 

            Name = name;
            Mark = mark;
            FullMark = fullMark;

        }
        // Functionality/Method (M)

        // Computing Function
        public double Compute_Pct() { 
        

        double percentage = (Mark / FullMark) * 100;
        return percentage;


        }

        // grade scaling Function
        public string Grade(double grade)
        {


            if (grade >= 85)
            {
                return ("Excellent grade! ");
            }
            else if (grade >= 75)
            {
                return("Very good Grade!");

            }
            else if (grade >= 65)
            {
                return ("Good Grade! ");
            }
            else if (grade >= 50)
            {
                return ("you passed ");
            }
            else
            {
                return (" you failed :( ");
            }

        }

        // Mark Getter
        public double Get_Mark()
        {

            return Mark;
        }

        // Mark Setter
        public void Set_Mark(double mark)
        {
            if (mark >= 0)
            {
            Mark = mark;
            }
            else
            {
                Console.WriteLine("The Mark is less than 0 hence it cannot be updated");
            }

        }

        // Full Mark Getter
        public double Get_FullMark()
        {
            return FullMark;
        }

        // Full Mark Setter
        public void Set_FullMark(double fullMark)
        {
            if (fullMark >= 0)
            {

            FullMark = fullMark;
            
            }
            else
            {
                Console.WriteLine("The Full Mark is less than 0 hence it cannot be updated");
            }

        }
    }
}
