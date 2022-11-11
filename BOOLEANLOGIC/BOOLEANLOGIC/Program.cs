using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOLEANLOGIC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int yourAge = Convert.ToInt32(Console.ReadLine());

          


            Console.WriteLine("Have you ever had a DUI?");
            bool DUI = Convert.ToBoolean(Console.ReadLine());
            
            
            


            Console.WriteLine("How many speeding tickets do you have?");
            int Tickets = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Qualified?");
            bool qual = (yourAge >= 18 && Tickets <= 3 && DUI == false);
            Console.WriteLine(qual);
            Console.ReadLine();



        }
    }
}
