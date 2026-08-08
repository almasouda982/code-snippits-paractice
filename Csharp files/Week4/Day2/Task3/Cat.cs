using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzizMohammed.Week4.Day2.Task3
{
    public class Cat : Animal
    {
        public bool IsIndoor { get; set; }

        public Cat(string name, int age, string color, bool isIndoor) : base(name, age, color)
        {
            IsIndoor = isIndoor;
        }


        //public string Meow(bool meow)
        //{
        //    if (meow == true)
        //    {
        //        return "Meow";
        //    }
        //    else
        //    {
        //        return "No Meow";
        //    }
        //}

        public override string DisplayInfo()
        {
            return $"{base.DisplayInfo()} The cat is indoors: {IsIndoor}";
        }

        public string Meow()
        {
            return "Meow";
        }

    }
}
