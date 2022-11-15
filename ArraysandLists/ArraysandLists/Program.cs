using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysandLists
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Select a number between 0-4");
            string[] numArray1 = {"Hello", "my", "name", "is", "Alex" };
            int user = Convert.ToInt32(Console.ReadLine());

            if (user> 4)
            {
                Console.WriteLine("This index that doesn’t exist. Please select a number 0-4");
            }

            Console.WriteLine(numArray1[user]);



            Console.WriteLine("Select a number between 1-9");
            int[] numArray = new int[] { 55, 52, 33, 67, 59, 12, 92, 18, 89 };
            int user2 = Convert.ToInt32(Console.ReadLine());
            if (user2 >9)
            {
                Console.WriteLine("This index that doesn’t exist. Please select a number 1-9");
            }

            Console.WriteLine(numArray[user2]);


            Console.WriteLine("Select a number between 0-2");
            List<string> intList = new List<string>();
            intList.Add("Hello");
            intList.Add("Good Morning");
            intList.Add("This is a string");
            int user3 = Convert.ToInt32(Console.ReadLine());

            if (user3 > 2)
            {
                Console.WriteLine("This index that doesn’t exist. Please select a number 0-2");
            }


            Console.WriteLine(intList[user3]);

            Console.ReadLine();



         





            
        }
    }
}
