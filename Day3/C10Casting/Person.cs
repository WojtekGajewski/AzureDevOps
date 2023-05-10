using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10Inheritence
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        internal string TestingAccessor;


        public void Speak()
        {
            Console.WriteLine("Hello");

            
        }

        public void Walk()
        {
            Console.WriteLine("I'm walking");
        }
    }
}
