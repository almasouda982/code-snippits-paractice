using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AzizMohammed.Week4.Day2.Task2
{

    /*
        // Motorcycle
        // Properties: Brand, Model, Price, HasSideCar
        // Method: DisplayDetails() => تعرض كل البيانات
        // Method: DoWheelie() => تطبع "Motorcycle is doing a wheelie!"
     * 
     */
    public class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }

        public Motorcycle(string brand, string model, double price, bool hasSideCar) : base(brand, model, price)
        {

            HasSideCar = hasSideCar;
            
        }

        //public string DoWheelie (bool Wheelie)
        //{
        //    if (Wheelie == true)
        //    {
        //    }
        //    else
        //    {
        //        return "Motorcycle is not doing a wheelie!";
        //    }
        //}


        public override string DisplayDetails()
        {
            return $"{base.DisplayDetails()} Has a side car: {HasSideCar}";
        }

        public override double GetPrice()
        {
            return Price;
        }

        public string DoWheelie()
        {
            return "The Motorcycle is doing a wheelie!";

        }
    }
    

}
