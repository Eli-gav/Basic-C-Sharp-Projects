using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSubmissions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            Console.WriteLine("What is your favorite movie?");
            string[] movies = { "Your favorite movie is " };
            string movieInput = Console.ReadLine();

            Console.WriteLine(movies + movieInput);


            //Part 2

            Console.WriteLine("Enter the less than 1. Type stop to exit");
            int infin = Convert.ToInt32(Console.ReadLine());

            while (infin < 1)
            {
                Console.WriteLine("Good Morning");

                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
            }


            //Part 3


            Console.WriteLine("Select a number less than 3");
            int user5 = Convert.ToInt32(Console.ReadLine());

            while (user5 <= 3)
            {
                Console.WriteLine("Counting down from: " + user5);
                user5--;

                if (user5 < 0)
                {
                    break;
                }

                if (user5 >= 4)
                    Console.WriteLine("Please select a number less than 3");


            }



            Console.WriteLine("Enter a number to count to 10");
            int userE = Convert.ToInt32(Console.ReadLine());


            while (userE < 11)
            {
                Console.WriteLine("Counting to 10: " + userE);
                userE++;
            }


            //Part 4
            Console.WriteLine("Search for an animal in our database");
            List<string> animals = new List<string>() { "cat", "dog", "frog", "rat", "moth" };
            string animalInput = Console.ReadLine();


            bool a = animals.Contains(animalInput);

            if (a == true)
            {
                Console.WriteLine(animalInput + " is in the database");
            }
            else
            {
                Console.WriteLine(animalInput + " is not the database");
            }


            //Part 5
            Console.WriteLine("Search for any fruit in our database");
            List<string> fruits = new List<string>() { "strawberry", "kiwi", "grapes", "berries", };
            string fruitInput = Console.ReadLine();


            bool f = fruits.Contains(fruitInput);

            if (f == true)
            {
                Console.WriteLine(fruitInput + " is in the database");
            }
            else
            {
                Console.WriteLine(fruitInput + " is not the database");
            }



            //Part 6
            List<string> subjects = new List<string>() { "A", "B", "C", "D" };
            List<string> subjects2 = new List<string>() { "A", "F", "G", "H", "J" };


            if (subjects == subjects2)
            {
                Console.WriteLine(subjects + "is not unique");
            }

            else
            {
                Console.WriteLine(subjects + "is unique");
            }




            Console.ReadLine();

        }
    }
}




