using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempratureConv
{
    internal class Temp
    {
        public static double Conv(int ch, double convert_into)
        {
            double converted = 0;
            if (ch == 1)
            {
                converted = (convert_into * 9 / 5) + 32;              
            }
            else
            {
                converted = (convert_into - 32) * 5 / 9;                  
            }
            return converted;
        }
    }
}
