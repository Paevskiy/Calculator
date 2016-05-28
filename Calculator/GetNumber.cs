using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Get
    {
        public static double Number(string s, ref int index)
        {
            var tmp = "";
            foreach (var c in s.Substring(index))
            {
                if (!Char.IsDigit(c))
                {
                    break;
                }

                index++;
                tmp += c;
            }

            return double.Parse(tmp);
        }
    }
}
