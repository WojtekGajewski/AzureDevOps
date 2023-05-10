using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10Inheritence
{
    internal class Programmer : Person
    {
        public string ProgrammingLanguage {  get; set; }

       
        private void Test()
        {
            TestingAccessor = "ok";
        }

        public void Code()
        {
            Console.WriteLine("Im coding with " + ProgrammingLanguage);
        }
    }
}
