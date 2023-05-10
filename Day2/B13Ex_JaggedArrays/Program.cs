using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace B13Ex_JaggedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string path = "http://tomaszles.pl/wp-content/uploads/2023/05/volleyball_players.csv";

            WebClient wc = new WebClient();
            string data = wc.DownloadString(path);

            string[] separator = new string[1] { "\r\n" };
            string[] rows = data.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            int numberOfRows = rows.Length;
            // int numberOfCollumns = rows[0].Split(';').Length;

            string[][] table = new string[numberOfRows][];

            for (int i = 0; i < numberOfRows; i++) 
                table[i] = rows[i].Split(';');

            //foreach (var row in table)
            //    Console.WriteLine(string.Join(" ", row));

            foreach (var row in table)
            {
                foreach (var cell in row)
                    Console.Write(cell + " ");

                Console.WriteLine();
            }

            // homework: how to import data to 2-dimensions array 

            Console.ReadKey();
        }
    }
}
