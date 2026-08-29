using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzizMohammed.Week4.Day2.Task2
{
    public abstract class Vehicle
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
        public double Price { get; set; }


        public Vehicle(string brand, string model, double price)
        {

            Brand = brand;
            Model = model;
            Price = price;
            
        }


        public virtual string DisplayDetails()
        {
            return $"Brand: {Brand}, Model: {Model}, Price: {Price}";
        }

        public abstract double GetPrice();
        
        



    }
}
