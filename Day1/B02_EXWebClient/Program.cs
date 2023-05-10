using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace B02_EXWebClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // char onlyOneCharacter = 'a';

            string searchChar = "°";
            string endChar = ">";

            while (true)
            {
                Console.WriteLine("Enter the city name");
                string city = Console.ReadLine();

                string address = $"https://www.google.com/search?q=weather+{city}";

                WebClient wc = new WebClient();
                string data = wc.DownloadString(address);

                try
                {
                    int index = data.IndexOf(searchChar);
                    int currentPosition = index;
                    int iterationCount = 0;

                    while (data.Substring(currentPosition, 1) != endChar)
                    {
                        iterationCount++;
                        currentPosition--;
                    }

                    string result = data.Substring(currentPosition + 1, index - currentPosition + 1);
                    Console.WriteLine(result);
                }
                catch (Exception)
                {
                    Console.WriteLine("Faild to retrieve temperature");
                    continue;
                }
                
            }

           

            Console.ReadKey();

        }
    }
}
