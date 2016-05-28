using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "1+2*5!-2^3";// работаю над, степенью со знаком "-"("2^(-2)") и скобками
            double r = Add.Sub(s);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}