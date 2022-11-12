using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight: ");
            int packWeight = Convert.ToInt32(Console.ReadLine());
            if (packWeight >=50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }


            Console.WriteLine("Please enter the package width: ");
            int packWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height: ");
            int packHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length: ");
            int packLength = Convert.ToInt32(Console.ReadLine());

            int allDem = (packWidth + packHeight + packLength);
            if (allDem > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            int compar = (packWidth * packHeight * packLength * packWeight)/100;

            
            
            Console.WriteLine("Your estimated total for shipping this package is: ");
            Console.WriteLine(compar + ".00$" + "  Thank you!");
            
            Console.ReadLine();


        }
    }
}
