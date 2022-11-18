using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                List<int> nums = new List<int>() { 4, 8, 12, 16, 22 };
                Console.WriteLine("Pick a number");
                int userInput = Convert.ToInt32(Console.ReadLine());

                foreach (int i in nums)
                {
                    Console.WriteLine(i / userInput);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type in number format instead of word");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please dont divide by zero");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}


                

               
              
                

