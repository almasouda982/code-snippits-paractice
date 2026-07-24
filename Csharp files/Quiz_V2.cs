using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp1.Practice
{
    internal class Quiz_V2
    {
        static void Main(string[] args)
        {
            Random random = new Random();




            //generate a 10 random multipication quiz correct or not correct
            for (int x = 1; 10>=x; x++)
            {
            int num1 = random.Next(1, 11);
            int num2 = random.Next(1, 11);


            Console.Write($"{x}. {num1} * {num2} = ");
            int ans = int.Parse(Console.ReadLine());

                if (num1 * num2 == ans)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("InCorrect");
                }



            }

            Console.ReadKey(true);
        }
    }
}
