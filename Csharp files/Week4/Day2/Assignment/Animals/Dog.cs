using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp1.Week4.Assignments.Vehicles
{
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, int age, string color, string breed) : base(name, age, color)
        {
            Breed = breed;
        }

        //public string Bark(bool bark)
        //{
        //    if (bark == true)
        //    {
        //        return "Bark";
        //    }
        //    else
        //    {
        //        return "No Bark";
        //    }
        //}

        public override string DisplayInfo()
        {
            return $"{base.DisplayInfo()} the breed is: {Breed}";
        }

        public override string MakesSound()
        {
            return "It goes Bark ";
        }

    }

}
