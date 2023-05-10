using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A05Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a1 = "a";
            string a2 = a1.ToUpper();

            int b1 = 3;
            int b2 = b1 + 1;
        //    Console.WriteLine(b2);

            string c = b2 + a2;

     //       Console.WriteLine(c);




            Console.ReadKey();
        }
    }
}
