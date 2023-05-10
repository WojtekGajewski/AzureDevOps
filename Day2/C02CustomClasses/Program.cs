using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace C02CustomClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is variable and this variable referes to new object 
            Calculator c = new Calculator();

            // c is only the handle (grip) to object 

            //   WebClient wc = new WebClient();

            Calculator c1; //what is it?  This is only variable
                           //
          
            new Calculator(); // usually we dont use it 


            Calculator c2; 

            // later...
            c2  = new Calculator();


            int g= c.CalculateSum(3, 4);
            int g2 = c.CalculateDifference(4, 3);

            Console.WriteLine(g);
            Console.WriteLine(g2);

            Console.ReadKey();
        }
    }
}
