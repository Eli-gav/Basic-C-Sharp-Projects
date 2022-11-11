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
            int hourlyRate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursWeek1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate?");
            int hourlyRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursWeek2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual Salary of Peron 1: ");

            int product = hourlyRate1 * hoursWeek1 * 56;
            Console.WriteLine(product);

            Console.WriteLine("Annual Salary of Peron 2: ");

            int product2 = hourlyRate2 * hoursWeek2 * 56;
            Console.WriteLine(product2);


            Console.WriteLine("Does Person 1 make more money than Person 2? ");

            bool result = product >= product2;
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
