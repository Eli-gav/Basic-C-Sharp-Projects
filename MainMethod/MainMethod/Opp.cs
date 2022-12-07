using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class Opp
    {
        public Opp()
        {
            one = 555;
            two = (int)(double)3.4455;
            three = "Your number is ";

        }

        public static int testOne(Opp opp)
        {
            return opp.one + opp.userInput;
        }

       

        public static int testTwo(Opp opp)
        {
            return (int)((int)opp.two * opp.userInput2) ;
        }

        public static string testThree(Opp opp)
        {
            return opp.three +  opp.userInput3;
        }

 



        public int one { get; set; }
        public int two { get; set; }
        public string three { get; set; }
        public int userInput { get; set; }
        public double userInput2 { get; set; }
        public string userInput3 { get; set; }
    }
}
