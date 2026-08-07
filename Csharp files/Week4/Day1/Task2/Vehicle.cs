using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp1.Week4.Day1.Task2
{
    public class Vehicle
    {
        /*
         * 
        // Vehicle
        // Properties: Brand, Model, Price
        // Method: DisplayDetails() => تعرض كل البيانات
        // Method: GetPrice() => ترجع السعر
         
         */

        public string Brand { get; set; }
        public string Model { get; set; }
        private double _price;
        public double Price {

            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("price cannot be less than 0");
                }
                else
                {
                    _price = value;
                }
            }
        
        
        }


        public Vehicle(string brand, string model, double price)
        {

            Brand = brand;
            Model = model;
            Price = price;
            
        }


        public string DisplayDetails()
        {
            return $"Brand: {Brand}, Model: {Model}, Price: {Price}";
        }

        public double GetPrice()
        {
            return _price;
        }



    }
}
