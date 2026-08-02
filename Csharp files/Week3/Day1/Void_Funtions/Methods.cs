using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstConsoleApp.Week3.Day1
{
    internal class Methods
    {


        //-----------------without param --------------------
        public void Compute_BMI()
        {



            Console.Write("Enter the patient's name: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter the patient's weight: ");
            int PatientWeight = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the patient's height: ");
            int PatientHeight = int.Parse(Console.ReadLine());



            double BMI = PatientWeight / Math.Pow(PatientHeight / 100.0, 2.0);

            Console.WriteLine();
            Console.WriteLine($"The patient {name} with their weight as {PatientWeight} and height as {PatientHeight} have a BMI score as: {BMI}");
            Console.WriteLine();


            if (BMI >= 30)
            {
                Console.WriteLine("Obese");
            }
            else if (BMI >= 25)
            {
                Console.WriteLine("Overweight");
            }
            else if (BMI >= 18.5)
            {
                Console.WriteLine("normal weight");
            }
            else
            {
                Console.WriteLine("Underweight");
            }

        }



        //-------------------- with params--------
        public void Compute_BMI2(string name, int PatientWeight, int PatientHeight)
        {
            double BMI = PatientWeight / Math.Pow(PatientHeight / 100.0, 2.0);

            Console.WriteLine();
            Console.WriteLine($"The patient {name} with their weight as {PatientWeight} and height as {PatientHeight} have a BMI score as: {BMI}");
            Console.WriteLine();


            if (BMI >= 30)
            {
                Console.WriteLine("Obese");
            }
            else if (BMI >= 25)
            {
                Console.WriteLine("Overweight");
            }
            else if (BMI >= 18.5)
            {
                Console.WriteLine("normal weight");
            }
            else
            {
                Console.WriteLine("Underweight");
            }
        }

        //------------------ without params---------
        public void Compute_PCT()
        {

            Console.Write("Enter the Name ");
            string fullname = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter the mark ");
            double mark = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the full mark ");
            double fullMark = double.Parse(Console.ReadLine());

            double percentage = (mark / fullMark) * 100;

            Console.WriteLine();

            Console.WriteLine($"{fullname}'s Calculated Percentage is:  {percentage}%");

            Console.WriteLine();

            if (percentage >= 85)
            {
                Console.WriteLine($"{fullname}'s Calculated Percentage is:  {percentage}% Excellent grade!");
            }
            else if (percentage >= 75)
            {
                Console.WriteLine($"{fullname}'s Calculated Percentage is:  {percentage}% Very good Grade!");

            }
            else if (percentage >= 65)
            {
                Console.WriteLine($"{fullname}'s Calculated Percentage is:  {percentage}% Good Grade!");
            }
            else if (percentage >= 50)
            {
                Console.WriteLine($"{fullname}'s Calculated Percentage is:  {percentage}% you passed");
            }
            else
            {
                Console.WriteLine($"{fullname}'s Calculated Percentage is:  {percentage}% you failed :( ");
            }


        }

        //------------------ with params---------
        public void Compute_PCT2(string fullname, double mark, double fullmark)
        {

            double percentage = (mark / fullmark) * 100;

            Console.WriteLine();

            if (percentage >= 85)
            {
                Console.WriteLine($"{fullname}'s Calculated Percentage is:  {percentage}% Excellent grade!");
            }
            else if (percentage >= 75)
            {
                Console.WriteLine($"{fullname}'s Calculated Percentage is:  {percentage}% Very good Grade!");

            }
            else if (percentage >= 65)
            {
                Console.WriteLine($"{fullname}'s Calculated Percentage is:  {percentage}% Good Grade!");
            }
            else if (percentage >= 50)
            {
                Console.WriteLine($"{fullname}'s Calculated Percentage is:  {percentage}% you passed");
            }
            else
            {
                Console.WriteLine($"{fullname}'s Calculated Percentage is:  {percentage}% you failed :( ");
            }
        }












        ////-------------------test/ignore

        ////------- without 

        public void Compute_PCTT()
        {
            List<string> list = new List<string>();
            string print = "";
            for (int i = 0; i < 5; i++)
            {
                // values insertion
                Console.Write("Enter the Name ");
                string name = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Enter the mark ");
                double mark = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Enter the full mark ");
                double fullMark = double.Parse(Console.ReadLine());
                double percentage = (mark / fullMark) * 100;



                if (percentage >= 85)
                {
                    print = ("an excellent grade!");
                }
                else if (percentage >= 75)
                {
                    print = ("a very good Grade!");

                }
                else if (percentage >= 65)
                {
                    print = "a good grade!";
                }
                else if (percentage >= 50)
                {
                    print = ("a passing");
                }
                else
                {
                    print = "bad you failed :( ";
                }
                // Print



                list.Add($"{name} amrk {mark} full mark {fullMark} and grade is {print} and the percentage is {percentage}");


            }
            // List Print
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

        }



        ////-------- with

        //public void Compute_PCTT2(string name, double mark, double fullmark)
        //{
        //    string print = "";
        //    List<string> list = new List<string>();

        //    for (int i = 0; i < 5; i++)
        //    {

        //        double percentage = (mark / fullmark) * 100;



        //        if (percentage >= 85)
        //        {
        //            print = ("an excellent grade!");
        //        }
        //        else if (percentage >= 75)
        //        {
        //            print = ("a very good Grade!");

        //        }
        //        else if (percentage >= 65)
        //        {
        //            print = "a good grade!";
        //        }
        //        else if (percentage >= 50)
        //        {
        //            print = ("a passing");
        //        }
        //        else
        //        {
        //            print = "bad you failed :( ";
        //        }
        //        // Print



        //        list.Add($"{name} amrk {mark} full mark {fullmark} and grade is {print} and the percentage is {percentage}");


        //    }
        //    // List Print
        //    foreach (string item in list)
        //    {
        //        Console.WriteLine(item);
        //    }

        //}






    }
}
