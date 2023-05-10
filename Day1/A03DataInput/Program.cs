using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A03DataInput
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your name:");

            string name = Console.ReadLine();

            name =  name.ToUpper();

            Console.WriteLine(name);


            string age = Console.ReadLine();

            int ageInt = Convert.ToInt32(age);

            ageInt = ageInt + 1;

            Console.WriteLine("Next year, you will be: " + ageInt);



            Console.ReadKey();

        }
    }
}
