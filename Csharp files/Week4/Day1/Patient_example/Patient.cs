//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FirstConsoleApp.Week3.Day2.OOP_Level3
//{
//    public class Patient
//    {
//        public string Name {  get; set; }

//        private double _weight;
//        public double Weight
//        {
//            get
//            { 
//                return _weight;
//            }
//            set
//            {
//                if (value > 0)
//                {
//                    _weight = value;
//                }
//                else
//                {
//                    Console.WriteLine("Weight Cannot be zero or negative...");
//                }
//            }
//        }
//        private double _height;
//        public double Height {

//            get
//            {
//                return _height;
//            }
//            set
//            {

//                if (value > 0)
//                {
//                    _height = value;
//                }
//                else
//                {
//                    Console.WriteLine("Height Cannot be zero or negative");
//                }


//            }
//        }


//        public Patient(string name, double weight, double height)
//        {
//            Name = name;
//            Weight = weight;
//            Height = height;
//        }

//        public double Get_BMI()
//        {
//            double BMI = Weight / Math.Pow((Height / 100), 2);
//            return BMI;
//        }

//        public string Get_Status(double status)
//        {
//            if (status >= 30)
//            {
//                return ("Obese");
//            }
//            else if (status >= 25)
//            {
//                return("Overweight");
//            }
//            else if (status >= 18.5)
//            {
//                return("Normal weight");
//            }
//            else
//            {
//                return ("Underweight");
//            }
//        }




//    }
//}