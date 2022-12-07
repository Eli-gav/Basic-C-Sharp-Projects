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
            Console.WriteLine("Your number plus 555 is " + (Opp.testOne(opp)));




            Console.WriteLine("Pick a decimal");
            double userInput2 = Convert.ToDouble(Console.ReadLine());
            opp.userInput2 = userInput2;
            Console.WriteLine("Your number multiplied by .4445 is  " + (Opp.testTwo(opp)));


            Console.WriteLine("Type in a number by letters ex. Five, Four");
            string userInput3 = Console.ReadLine();
            opp.userInput3 = userInput3;
            

            Console.WriteLine( (Opp.testThree(opp)));



            

            Console.ReadLine();
        }
    }
}
