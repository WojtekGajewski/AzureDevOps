using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A10Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 1;
            //Console.WriteLine(a);
            //a++;
            //Console.WriteLine(a);
            //a++;
            //Console.WriteLine(a);
            //a++;
            //Console.WriteLine(a);
            //a++;
            //Console.WriteLine(a);

            int count = 0;
            while (count < 10) 
            {
                count++;
                Console.WriteLine(count);
            }


            string equation = "10 200";
                             //012345                
                           //  i
            int index  = 0;
            int spacePosition = -1;
            while (index<equation.Length)
            {
                if (equation.Substring(index, 1) == " ")
                {
                    spacePosition = index;
                    break; // exits from while 
                }
                index++;
            }
            // we have implemented a custom function that works silimary to the build-in "idnexof"


            Console.ReadKey();
        }
    }
}
