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
            Console.WriteLine("Type in a word");
            string[] movies = { "Your word is ", "Your word in a sentence is " };
            string movieInput = Console.ReadLine();

           var i = 0;
            foreach (string m in movies)
            {
                 movies[i] = movies[i] + movieInput;
                 i++;
            }   
            foreach (string m in movies)
            {
                Console.WriteLine(m);
            }
                




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

            var a = false;

            int n = 0;
            for ( n = 0; n < 5; n++)
            {
                if (animalInput == animals[n])
                {
                    a = true;
                    break;

                }

                    
            }

            if (a == true)
            {
                Console.WriteLine(animalInput + " is in the database at index " + n);
            }
            else
            {
                Console.WriteLine(animalInput + " is not the database");
            }


            //Part 5
            Console.WriteLine("Search for any fruit in our database");
            List<string> fruits = new List<string>() { "strawberry", "kiwi", "grapes", "berries", "kiwi" };
            string fruitInput = Console.ReadLine();

            

            var q = 5;
  
            bool w = false;
            for (q = 0; q < 5; q++)
            {
                if (fruitInput == fruits[q])
                {
                    w = true;
                    Console.WriteLine(fruitInput + " is in the database at index " + q);

                }


            }


            if (w == false)
            {
                Console.WriteLine(fruitInput + " is not the database");
            }

  



            //Part 6
            List<string> subjects = new List<string>() { "A", "B", "C", "D", "A" };
            List<string> subjects2 = new List<string>() { } ;

            foreach (string s in subjects)
            {
                if (subjects2.Contains(s))
                {
                    Console.WriteLine(s + " is not unique");
                }

                else
                {
                    Console.WriteLine(s + " is unique");
                }
                subjects2.Add(s);

            }


            Console.ReadLine();

        }
    }
}





