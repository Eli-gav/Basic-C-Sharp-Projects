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
            string[] movies = { "Mulan", "Star Wars", "Hocus Pocus", "Spider Man", "Taxi Driver" };
            string movieInput = Console.ReadLine();




            for (int m = 0; m < movies.Length; m++)
            {
                Console.WriteLine(movies[m]);
            }



            {
                Console.WriteLine("New movie added : " + movieInput);
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


            Console.WriteLine("Select a number less than 5");
            int user5 = Convert.ToInt32(Console.ReadLine());

            if (user5 >= 5)
            {
                Console.WriteLine("Please select a number less than 5");
                int user6 = Convert.ToInt32(Console.ReadLine());
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

            foreach (string animal in animals)
            {
                if (animal == animalInput)
                {
                    Console.WriteLine("Animal Exists : " + animal);
                }
                else

                {
                    Console.WriteLine("Sorry your animal does not exist.");
                }
            }



                //Part 5
                Console.WriteLine("Search for any fruit in our database");
                List<string> fruits = new List<string>() { "strawberry", "kiwi", "grapes", "berries", "kiwi" };
                string fruitInput = Console.ReadLine();

                foreach (string fruit in fruits)
                {
                    if (fruit == fruitInput)
                    {
                        Console.WriteLine("Fruit Exists : " + fruit);
                    }
                    else

                    {
                        Console.WriteLine("Sorry your entry does not exist.");

                    }
                }
                    


                    //PART 6
                    List<string> subjects = new List<string>() { "A", "B", "C", "D", "A" };



                    foreach (string subject in subjects)
                    {
                        if (subject == subject)
                            Console.WriteLine(subject + " is not unique");

                        else
                        {
                            Console.WriteLine(subject + " is unique");
                        }

                    }



                }
            }
        }
    


