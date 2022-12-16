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
            two = (decimal).4455;
            three = 44;

        }

        public int testOne(Opp opp)
        {
            return opp.one + opp.userInput;
        }



        public decimal testTwo(Opp opp)
        {
            return opp.two * opp.userInput2;
        }

        public int testThree(Opp opp)
        {

            return opp.three + Convert.ToInt32(opp.userInput3);
        }





        public int one { get; set; }
        public decimal two { get; set; }
        public int three { get; set; }
        public int userInput { get; set; }
        public decimal userInput2 { get; set; }
        public string userInput3 { get; set; }
    }
}
