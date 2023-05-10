using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B10MultidimensionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] singleDimensionArray = new string[3];

            string[,] twoDimensionsArray = new string[4,2]; // total 8 elements 

            string[,,] threeDimenisonArray = new string[2, 3, 2];

            threeDimenisonArray[0, 0, 0] = "a";
            threeDimenisonArray[0,0, 1] = "b";

            int length = threeDimenisonArray.Length; // 2*3*2 == 12

            int firstDimenstionSize= threeDimenisonArray.GetLength(1); // 3 

            twoDimensionsArray[0, 0] = "A";
            twoDimensionsArray[1, 0] = "B";
            twoDimensionsArray[2, 0] = "C";
            twoDimensionsArray[3, 0] = "D";

            twoDimensionsArray[0, 1] = "E";
            twoDimensionsArray[1, 1] = "F";
            twoDimensionsArray[2, 1] = "G";
            twoDimensionsArray[3, 1] = "H";

            Console.WriteLine(" case 1: --- row wise ---");

            for (int i = 0; i < twoDimensionsArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensionsArray.GetLength(1); j++)
                    Console.Write(twoDimensionsArray[i, j] + " ");

                Console.WriteLine();
            }

            Console.WriteLine(" case 2: --- collumn wise ---");
            for (int i = 0; i < twoDimensionsArray.GetLength(1); i++)
            {
                for (int j = 0; j < twoDimensionsArray.GetLength(0); j++)
                    Console.Write(twoDimensionsArray[j,i] + " ");

                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
