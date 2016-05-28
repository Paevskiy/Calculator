using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Add
    {
        public static double Sub(string s)
        {
            int index = 0;
            var v = Mul.Div(s, ref index);
            while (index < s.Length)
            {
                if (s[index] == '+')
                {
                    index++;
                    v += Mul.Div(s, ref index);
                }
                else if (s[index] == '-')
                {
                    index++;
                    v -= Mul.Div(s, ref index);
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }

            return v;
        }
    }
}
