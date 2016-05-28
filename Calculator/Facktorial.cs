using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Fack
    {
        public static double torial(string s, ref int index)
        {
            double v = Get.Number(s, ref index);
            double result = 1;
            while (index < s.Length)
            {
                if (s[index] == '!')
                {
                    index++;
                    double f = 1;
                    while (f<=v)
                    {
                        result *= f;
                        f++;
                    }
                    return result;
                    
                }
                {
                    break;
                }
            }

            return v;
        }
    }
}
