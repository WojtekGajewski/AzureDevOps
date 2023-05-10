using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05EX_TextManager
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // what is var ? 

            string a = "john";
            int b = 4;

            var c = "john";
            var d = 5;

          //  c = 5; // this is not dynamic type !!

            var stringBuilders = new List<List<StringBuilder>>();

            dynamic e = 5;
            e = "john";


            // add comment 
        }
    }
}
