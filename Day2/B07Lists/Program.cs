using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B07Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cityArray = { "warsaw", "berlin", "paris" }; // arrays have fix length

            string exampleString = "warsaw";
            char exampleChar = 'g';

            List<string> list = new List<string>(); // empty list 

            List<string> list2 = null; // this is null list so i cannot use it 

            //list2.Add("xx"); // cannot use methods on null variables

            list.Add("warsaw");
            list.Add("berlin");
            ///......
            ///
            list.Insert(1, "paris"); // warsaw, paris, berlin 

            string city1 = list[0];// frist element 
            string city3 = list[list.Count -1]; //last element 

            list.RemoveAt(1); // removes the second element (indexed from 0)
            list.Remove("paris"); // removes the frist occurence of paris 

            //list.RemoveAll()



        }
    }
}
