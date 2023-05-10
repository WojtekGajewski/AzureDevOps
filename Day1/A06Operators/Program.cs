using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A06Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;

            bool isEqual = a == 1;

            a = a + 1;
            a++; // increment by  1

            a += 5; //inrease the value a by 5 

            a *= 2; // multiply the value by 2 

            a -= 5; // decrease by 5 

            a /= 2;


            bool isLess = a < 5;

            bool isGreaterOrEqual = a >= 5;

            bool orCondition = a < 5 || a > 10; // OR operator 

            bool andCondition = a > 5 && a < 10;

            bool isdifferent = !(a == 5);

            


        }
    }
}
