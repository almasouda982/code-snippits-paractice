using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BootCamp1.Week4.Assignment.Animals
{
    public class Bird : IAnimal
    {

        public string Name { get; set; }
        public string Color { get; set; }
        public bool CanFly { get; set; }

        public Bird(string name, string color, bool canFly)
        {
            Name = name;
            Color = color;
            CanFly = canFly;
        }

        public string DisplayInfo()
        {
            return $"Name: {Name}, Color {Color}, Can It fly? {CanFly}";
        }

        public string MakesSound()
        {
            return $" It goes Tweet ";
        }


    }
}
