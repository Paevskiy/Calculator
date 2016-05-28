using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Mul
    {
        public static double Div(string s, ref int index)
        {
            var v = Deg.ree(s, ref index);
            while (index < s.Length)
            {
                if (s[index] == '*')
                {
                    index++;
                    v *= Deg.ree(s, ref index);
                }
                else if (s[index] == '/')
                {
                    index++;
                    v /= Deg.ree(s, ref index);
                }
                else
                {
                    break;
                }
            }

            return v;
        }
    }
}
