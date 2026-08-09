using BootCamp1.Week4.Assignment.Animals;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp1.Week4.Assignments.Vehicles
{
    public abstract class Animal : IAnimal
    {
        public string Name {  get; set; }
        private int _age;
        public int Age {
            get
            {
                return _age;
            }
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Not Possible for age to be negative or 0");
                }

                else
                {
                    _age = value;
                }
            }
        }
        public string Color { get; set; }

        public Animal(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }

        public virtual string DisplayInfo()
        {
            return $"The Animal's Name: {Name}, Age: {Age}, Color: {Color}";
        }

        public virtual string MakesSound()
        {
            return "";
        }
    }
}
