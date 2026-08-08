using FirstConsoleApp.Week4.Day1.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzizMohammed.Week4.Day2.Task2
{

    /*

        //VehicleTest
        //Create instances  of Vehicle, Car and Motorcycle, set their properties
        //call their methods to display details and perform actions.

     */

    internal class VehicleTest
    {
        static void Main(string[] args)
        {

            //Vehicle v1 = new Vehicle("Toyoto", "Camrey", 45000);
            //Console.WriteLine( v1.DisplayDetails());


            List<Vehicle> vehs = new List<Vehicle>()
            {
                //new Vehicle("Ford", "Expediton", 120000),
                new Car("Toyota", "Camrey", 90000, 4),
                new Motorcycle("Harley", "IDK", 200000, false)
            };

            foreach (var veh in vehs)
            {

                string details = $"the price is: {veh.GetPrice()} {veh.DisplayDetails()}.";

                if (veh is Car car)
                {
                    Console.Write(details);
                    Console.WriteLine($"The car engine {car.StartEngine()}");
                }
                else if (veh is Motorcycle motorcycle)
                {
                    Console.Write(details);
                    Console.WriteLine($"{motorcycle.DoWheelie()}");
                }
                else
                {

                    Console.WriteLine(details);

                }
                Console.WriteLine("=========================================================");

            }
            Console.ReadKey();



        }

    }
}
