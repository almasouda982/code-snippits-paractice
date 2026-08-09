using BootCamp1.Week4.Assignment.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp1.Week4.Assignments.Vehicles
{
    internal class AnimalTest
    {
        static void Main(string[] args)
        {
            IAnimal[] animals =
            {
                //new Animal("Leo", 12, "Yellow"),
                new Dog("Spark", 7, "Golden", "Golden Retriever"),
                new Cat("Coca", 8, "Brown", true),
                new Fish("Nemo", "Orange", true),
                new Bird("Tweety", "Yellow", true)


            };


            foreach (var animal in animals)
            {
                string details = $" {animal.DisplayInfo()}.";

                if (animal is Bird bird)
                {
                    Console.Write(details);
                    Console.WriteLine($" {animal.MakesSound()}");

                }
                else if (animal is Fish fish)
                {
                    Console.Write(details);
                    Console.WriteLine($" {animal.MakesSound()}");


                }
                else if (animal is Cat cat)
                {
                    Console.Write(details);
                    Console.WriteLine($" {cat.Meow()}");

                }
                else if (animal is Dog dog)
                {
                    Console.Write(details);
                    Console.WriteLine($" {dog.Bark()}");

                }
            }



            //foreach (var creature in creatures)
            //{
            //    if (creature is Dog dog)
            //    {
            //        Console.Write(details);
            //        Console.WriteLine($". It goes {dog.Bark()}");

            //    }
            //    else if (creature is Cat cat)
            //    {
            //        Console.Write(details);

            //    }
            //    else
            //    {
            //        Console.WriteLine(details);
            //    }
            //    Console.WriteLine("=================================================");
            //}
            Console.ReadKey();
        }

    }
}


