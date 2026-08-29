using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp1.Week4.Assignment.Animals
{
    public class Fish :IAnimal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public bool IsFreshWater { get; set; }

        public Fish(string name, string color, bool isFreshWater)
        {
            Name = name;
            Color = color;
            IsFreshWater = isFreshWater;

        }

        public string DisplayInfo()
        {
            return $"Name: {Name}, Color {Color}, Is It in fresh waters? {IsFreshWater}";
        }

        public string MakesSound()
        {
            return $" It goes Burp... I think... ";
        }
    }
}
