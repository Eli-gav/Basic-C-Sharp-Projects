using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Got got = new Got();

            Console.WriteLine("Pick a number to + - or * ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            got.userInput = userInput;

            Console.WriteLine("Your number added is " + (Got.AddNumber(got)));
            Console.WriteLine("Your number subtracted is " + (Got.SubNumber(got)));
            Console.WriteLine("Your number multiplied is " + (Got.MultNumber(got)));

            Console.ReadLine();


        }
    }
