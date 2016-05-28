using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Deg
    {
        public static double ree(string s, ref int index)
        {
            double v = Fack.torial(s, ref index);
            while (index < s.Length)
            {
                if (s[index] == '^')
                {
                    index++;
                    v = Math.Pow(v,Fack.torial(s, ref index));
                }
                {
                    break;
                }
            }

            return v;
        }
    }
}
