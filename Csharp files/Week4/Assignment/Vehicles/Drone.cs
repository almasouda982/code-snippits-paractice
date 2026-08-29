using BootCamp1.Week4.Assignments.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp1.Week4.Assignment.Vehicles
{
    public class Drone : IVehicle
    { 
        public string Model { get; set; }

        public Drone(string model)
        {
            Model = model;
        }

        public string DisplayDetails()
        {
            return $"The Model is: {Model}";
        }





    }
}
