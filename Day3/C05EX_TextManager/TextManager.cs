using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05EX_TextManager
{
    internal class TextManager
    {
        public string FindLongesWord(string sentence)
        {
            string[] words= sentence.Split(' ');

            if (sentence.Length < 1 || words.Length < 1)
                throw new Exception("your sentence is to short");

            string currentLognest = string.Empty;
            foreach(string word in words)
                if(word.Length > currentLognest.Length) 
                    currentLognest = word;

            return currentLognest;

        }

        public string[] FindAllLongestWords(string sentence)
        {
            string longst = FindLongesWord(sentence);
            return FindWordsOfGivenLength(longst.Length, sentence);
        }

        private string[] FindWordsOfGivenLength(int length, string sentence)
        {
            List<string> foundWords = new List<string>();
            foreach (var word in sentence.Split(' '))
            {
                if(word.Length == length)
                    foundWords.Add(word);
            }
            return foundWords.ToArray();


        }

    }
}
