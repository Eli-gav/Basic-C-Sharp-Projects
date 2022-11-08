using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();


            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is:" + yourName);

            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("You are currently on: " + yourCourse);

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            Console.WriteLine("You are currently on page: " + pageNumber);

            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false.'");
            bool myAnswer = false;
            string yourAnswer = Console.ReadLine();
            Console.WriteLine("Your answer: " + myAnswer);

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string myEx = Console.ReadLine();
            Console.WriteLine("Your experiences: " + myEx);

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string myFeedback = Console.ReadLine();
            Console.WriteLine("Your feedback: " + myFeedback);

            Console.WriteLine("How many hours did you study today?");
            int myGoal = 8;
            string hoursStudy = Console.ReadLine();
            Console.WriteLine("You worked this many hours today: " + hoursStudy + " Your goal for today: " + myGoal);


            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
