using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.Level2
{
    internal class Methods
    {

            public void Compute_BMI()
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

            }

            public void Compute_PCT()
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

            public void Check_day()
            {
                Console.WriteLine("Enter Your Day:");
                int day = int.Parse(Console.ReadLine());
                string today = "";


                switch (day)
                {
                    case 1:
                        today = ("Sunday");
                        break;

                    case 2:
                        today = ("Monday");
                        break;
                    case 3:
                        today = ("Tuesday");
                        break;
                    case 4:
                        today = ("wednesday");
                        break;
                    case 5:
                        today = ("Thurday");
                        break;
                    case 6:
                        today = ("Friday");
                        break;
                    case 7:
                        today = ("Saturday");
                        break;

                    default:
                        today = ("Invaild Day");
                        break;
                }

                Console.WriteLine(today);
            }

            public void Check_Workday()
            {
                Console.Write("Enter Your Day: ");
                int Day = int.Parse(Console.ReadLine());
                string input = "";



                if (Day >= 1 && Day <= 5)
                {
                    input = "WorkDay";
                }
                else if (Day == 6 || Day == 7)
                {
                    input = "OffDay";
                }
                else
                {
                    input = "Invalid input";
                }



                Console.WriteLine(input);
            }

            public void Quiz()
            {
                Random random = new Random();
                //generate a 10 random multipication quiz correct or not correct
                int count = 0;
                for (int x = 1; 10 >= x; x++)
                {
                    int num1 = random.Next(1, 11);
                    int num2 = random.Next(1, 11);

                    Console.Write($"Question({x}): {num1} * {num2} = ");
                    int ans = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (num1 * num2 == ans)
                    {
                        Console.WriteLine("Correct!");
                        count += 10;
                    }
                    else
                    {
                        Console.WriteLine("Wrong");
                    }
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine();


                }
                // calculate score and grade
                if (count >= 90)
                {
                    Console.WriteLine($"Your grade is A and score is {count}/100");
                }
                else if (count >= 80)
                {
                    Console.WriteLine($"Your grade is B and score is {count}/100");

                }
                else if (count >= 70)
                {
                    Console.WriteLine($"Your grade is C and score is {count}/100");

                }
                else if (count >= 60)
                {
                    Console.WriteLine($"Your grade is D and score is {count}/100");
                }

                else
                {

                    Console.WriteLine($"Your grade is F and score is {count}/100 you failed");

                }

            }

            public void Compute_Salary()
            {
                List<string> list = new List<string>();

                for (int i = 1; i <= 3; i++)
                {

                    Console.Write("Enter Employee Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Employee Salary: ");
                    double salary = double.Parse(Console.ReadLine());


                    double annualSalary = salary * 12;

                    list.Add($"Employee name:{name} Salary:{salary} Annual Salary:{annualSalary}");

                }
                foreach (string item in list)
                {
                    Console.WriteLine(item);
                    Console.WriteLine();

                }

            }

            public void Login()
            {
                Console.Write("Enter Username: ");
                string username = Console.ReadLine();

                Console.Write("Enter Password: ");
                string password = Console.ReadLine();


                if (username == "admin" && password == "12345")
                {
                    Console.WriteLine("Login Successful");
                }
                else
                {
                    Console.WriteLine("Login Failed");
                }


            }

            public void Calculator()
            {
                Console.Write("Enter First Number ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Enter Second Number ");
                int num2 = int.Parse(Console.ReadLine());

                Console.Write("Enter a math operator (+,-,*, or /): ");
                string op = Console.ReadLine();
                Console.WriteLine();
                if (op == "+")
                {
                    Console.WriteLine($"{num1} + {num2} = " + (num1 + num2));
                }
                else if (op == "-")
                {
                    Console.WriteLine($"{num1} - {num2} = " + (num1 - num2));

                }
                else if (op == "*")
                {
                    Console.WriteLine($"{num1} * {num2} = " + (num1 * num2));

                }
                else if (op == "/")
                {
                    Console.WriteLine($"{num1} / {num2} = " + (num1 / num2));

                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }

            }

        }
    }
