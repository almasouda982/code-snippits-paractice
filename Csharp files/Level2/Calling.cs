using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.Level
{
    internal class Calling
    {
        // task
        /*
         * create a methods calass with all methods
         * 
         */
        static void Main(string[] args)
        {



            Console.WriteLine("Chose your funtion \n1.Compute BMI\n2.Compute PCT");
            int input = int.Parse(Console.ReadLine());



            switch (input)
            {
                case 1:
                    BMI();
                    break;
                case 2:
                    Compute_PCT();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
                
            }



            Console.ReadKey(true);
        }

        static void BMI()
        {
            /*

          //Compute_BMI 

          // Enter Patient Name:
          // Enter Patient Weight: 87
          // Enter Patient Height: 187


          // BMI = weight /       (height/100)^2


          // print Patient Name:
          //print Patient Weight:
          // print Patient Height:
          // print Patient BMI: 18 - 30

          *
          *
          */



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

            // if >=30  obese
            // if bmi >=25  and <30 overweight
            // if >18.5 <25 normal weight
            // <18.5 underwightl

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




            Console.ReadKey(true);
        }

        static void Compute_PCT()
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






            Console.ReadKey(true);
        }

    }
}
