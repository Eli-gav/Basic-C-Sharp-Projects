using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Opp opp = new Opp();

            Console.WriteLine("Pick your number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number plus 555 is " + opp.testOne(userInput));




            Console.WriteLine("Pick a decimal");
            decimal userInput2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Your number multiplied by .4445 is  " + opp.testOne(userInput2));


            Console.WriteLine("Type in a number");
            string userInput3 = Console.ReadLine();
            Console.WriteLine("Your number is " + opp.testOne(userInput3));





            Console.ReadLine();
        }
    }
}

