using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A02StringOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "The quick brown fox jumps over the lazy dog";
                            // 01234
            int stringLength = sentence.Length;

            Console.WriteLine(stringLength);

            string s1 = sentence.Substring(4); //quick brown fox jumps over the lazy dog
            Console.WriteLine(s1);

            string s2=  sentence.Substring(4, 5);

            Console.WriteLine(s2);

            bool containsWord = sentence.Contains("jumps");

            Console.WriteLine(containsWord);

            bool b1 = true;
            bool b2 = false;


            string loweCase = sentence.ToLower();
            string upperCase = sentence.ToUpper();

            string s3 = "the" + "qucik" + "brown";

            string s4 = sentence + " again";

            string s5 = "quick".ToUpper();

            string s7 = sentence.Replace("jumps", "leaps"); //"The quick brown fox leaps over the lazy dog"

            int position = sentence.IndexOf("quick"); // 4

            Console.ReadKey();


        }
    }
}
