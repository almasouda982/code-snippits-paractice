using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzizMohammed.Week4.Day2.Task2
{

    /*
     * 
     * 
        // Car
        // Properties: Brand, Model, Price, NumberOfDoors
        // Method: DisplayDetails() => تعرض كل البيانات
        // Method: StartEngine() => تطبع "Car Engine Started"

     */
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }


        public Car(string brand, string model, double price, int numberOfDoors) : base(brand, model, price) 
        {
            NumberOfDoors = numberOfDoors;
            
        }


        //public string StartEngine(bool status)
        //{
        //    if (status == true)
        //    {
        //        return $"Car Engine Started";
        //    }
        //    else
        //    {
        //        return $"Car Engine Off";
        //    }
        //}


        public override string DisplayDetails()
        {
            return $"{base.DisplayDetails()} The number of doors is: {NumberOfDoors}";
        }

        public string StartEngine()
        {
            return $"Car Engine Started";
        }

        public override double GetPrice()
        {
            return Price;
        }


    }


}
