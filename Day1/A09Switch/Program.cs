using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A09Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a digit");

            int digit = Convert.ToInt32(Console.ReadLine());

            if (digit == 1)
                Console.WriteLine("one");
            else if (digit == 2)
                Console.WriteLine("two");
            else if (digit == 3)
                Console.WriteLine("three");
            else if (digit == 4)
                Console.WriteLine("four");
            else
                Console.WriteLine("other");

            switch (digit) 
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                default: 
                    Console.WriteLine("other");
                    break;
            }

        }
    }
}
