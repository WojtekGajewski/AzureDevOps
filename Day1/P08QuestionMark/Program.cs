using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08QuestionMark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  int a = null; // syntax error 
            int? b = null; //now b can store null value
                           
            string c = null; // its not a problem beause 
            // string is by default nullable type 

            //string? d = null; // syntax error 

            bool d = false;
            bool? e = null;



        }
    }
}
