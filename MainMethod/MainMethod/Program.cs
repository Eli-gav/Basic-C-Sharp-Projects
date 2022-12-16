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
            opp.userInput = userInput;
            Console.WriteLine("Your number plus 555 is " + opp.testOne(opp));




            Console.WriteLine("Pick a decimal");
            decimal userInput2 = Convert.ToDecimal(Console.ReadLine());
            opp.userInput2 = userInput2;
            Console.WriteLine("Your number multiplied by .4445 is  " + opp.testTwo(opp));


            Console.WriteLine("Type in a number");
            string userInput3 = Console.ReadLine();
            opp.userInput3 = userInput3;


            Console.WriteLine("Your number is " + opp.testThree(opp));





            Console.ReadLine();
        }
    }
}

