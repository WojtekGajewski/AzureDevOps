using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11Exerciseloops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence");
            string sentence = Console.ReadLine().ToUpper();

            Console.WriteLine("Enter a word");
            string word = Console.ReadLine().ToUpper();

            int index = 0;
            int count = 0;

            while (index <= sentence.Length - word.Length) 
            {
                string substring = sentence.Substring(index, word.Length);
                if (substring == word)
                    count++;

                index++;
            }

            string pattern = "The word/character '{0}' occurs in the given sentence {1} times.";

            Console.WriteLine(string.Format(pattern,word,count));

            Console.ReadKey();

        }
    }
}
