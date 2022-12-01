using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsSubmission
{
    public class Got
    {
        public Got()
        {
            storeNum = 2;
            //userInput = 4;
        }

        public static int AddNumber(Got got)
        {
            return got.storeNum + got.userInput;
        }

        public static int SubNumber(Got got)
        {
            return got.storeNum - got.userInput;
        }


        public static int MultNumber(Got got)
        {
            return got.storeNum * got.userInput;
        }




        public int storeNum { get; set; }
        public int userInput { get; set; }
    }
}
