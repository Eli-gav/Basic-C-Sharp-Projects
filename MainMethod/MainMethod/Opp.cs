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

        public int testOne(int a)
        {
            return a + one;
        }



        public int testOne(decimal b)
        {
            return (int)(b * two);
          
        }

        public int testOne(string c)
        {

            return (int)(Convert.ToInt32(c) + three);
                
         
        }





        public int one { get; set; }
        public decimal two { get; set; }
        public int three { get; set; }
        public int userInput { get; set; }
        public decimal userInput2 { get; set; }
        public string userInput3 { get; set; }
    }
}
