using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B15ConversionsArrayToLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "a", "b", "c" };

            List<string> list =  array.ToList();

            string[] array2= list.ToArray(); 
        }
    }
}
