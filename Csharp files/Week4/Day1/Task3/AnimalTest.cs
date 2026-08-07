using BootCamp1.Week4.Day1.Task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp1.Week4.Day1.Task3
{
    internal class AnimalTest
    {
        static void Main(string[] args)
        {
            List<Animal> creatures = new List<Animal>()
            {
                new Animal("Leo", 12, "Yellow"),
                new Dog("Spark", 7, "Golden", "Golden Retriever"),
                new Cat("Coca", 8, "Brown", true)


            };

            foreach(var creature in creatures)
            {
                Console.WriteLine(creature.DisplayInfo());
                if (creature is Dog dog)
                {

                    Console.WriteLine($"{dog.Bark(true)}");

                }
                else if (creature is Cat cat)
                {

                    Console.WriteLine($"{cat.Meow(false)}");

                }
                Console.WriteLine("=================================================");
            }
            Console.ReadKey();
        }

    }
}


