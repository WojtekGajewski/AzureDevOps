using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B03ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 0;
            string s = "dog";

            

            try
            {
                double c = a / b;

                string s1 = s.Substring(3, 1);

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("you cannot divide by zero");
                File.AppendAllText("c:\\data\\errors\\errorlog.txt", Environment.NewLine + ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("You provided an incorrect index");
                File.AppendAllText("c:\\data\\errors\\errorlog.txt", Environment.NewLine + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong" );
                File.AppendAllText("c:\\data\\errors\\errorlog.txt", Environment.NewLine + ex.Message);
            }
           

            Console.ReadKey();
                    


        }
    }
}
