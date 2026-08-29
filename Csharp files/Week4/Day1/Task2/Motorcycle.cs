using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp1.Week4.Day1.Task2
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

        public string DoWheelie (bool Wheelie)
        {
            if (Wheelie == true)
            {
                return "Motorcycle is doing a wheelie!";
            }
            else
            {
                return "Motorcycle is not doing a wheelie!";
            }
        }
    }
    

}
