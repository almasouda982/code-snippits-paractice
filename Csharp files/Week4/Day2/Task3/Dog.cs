using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzizMohammed.Week4.Day2.Task3
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

        public string Bark()
        {
            return "Bark";
        }

    }

}
