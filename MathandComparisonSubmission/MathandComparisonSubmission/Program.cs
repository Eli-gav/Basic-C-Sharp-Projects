using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathandComparisonSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly rate?");
            string hourlyRate1 = Console.ReadLine();
            Console.WriteLine("Hourly rate = " + hourlyRate1);
            Console.WriteLine("Hours worked per week?");
            string hourWeek1 = Console.ReadLine();
            Console.WriteLine("Hours worked per week = " + hourWeek1);

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate?");
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("Hourly rate = " + hourlyRate2);
            Console.WriteLine("Hours worked per week?");
            string hourWeek2 = Console.ReadLine();
            Console.WriteLine("Hours worked per week = " + hourWeek2);

            Console.WriteLine("Annual Salary of Peron 1: ");

            string ann1 = "55,000";
            Console.WriteLine(ann1);


            Console.WriteLine("Annual Salary of Peron 2: ");

            string ann2 = "33,000";
            Console.WriteLine(ann2);

            Console.WriteLine("Does Person 1 make more money than Person 2? ");

            bool moreMon = 55 > 33 ;
            Console.WriteLine(moreMon.ToString());
            Console.ReadLine();

        }
    }
}
