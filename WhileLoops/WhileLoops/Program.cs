using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is the value of x?");
            Console.WriteLine("-15 + (-5x) = 0");
            int num = Convert.ToInt32(Console.ReadLine());
            bool correctNum = num == -3;

            do
            {
                switch (num)
                {
                    case 3:
                        Console.WriteLine("You guessed 3. Close but try again");
                        Console.WriteLine("Guess a new number");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case -3:
                        Console.WriteLine("You got -3. That is Correct");
                        correctNum = true;
                        break;
                    default:
                        Console.WriteLine("You're not even close. Try again.");
                        Console.WriteLine("Guess a new number");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;

                }

            }
            while (!correctNum);
            {
            }

            Console.WriteLine("Press space to count to 10");

            int i = 0;
            while (i < 11)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadLine();


        }
    }
}
