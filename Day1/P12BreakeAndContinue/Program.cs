using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12BreakeAndContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            // break
            //string equation = "10 200";
            ////012345                
            ////  i
            //int index = 0;
            //int spacePosition = -1;
            //while (index < equation.Length)
            //{
            //    if (equation.Substring(index, 1) == " ")
            //    {
            //        spacePosition = index;
            //        break; // exits from while 
            //    }
            //    index++;
            //}

            string equation = "10 200";
            //012345                
            //  i
            int index = 0;
            int spacePosition = -1;
            while (index < equation.Length)
            {
                if (equation.Substring(index, 1) == " ")
                {
                    spacePosition = index;

                    if(index == 2)
                        continue; // skips actual iteration 
                }
                index++;
            }

        }
    }
}
