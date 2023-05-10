using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04EX_Calculator
{
    internal class Calculator
    {
        public double? PerformOperation(int a, int b, char symbol)
        {
            string operation = Convert.ToString(symbol);

            return CalculateOperation(a, b, operation);
        }

        private double? CalculateOperation(int a, int b, string operation)
        {
            double? result = null;
            if (operation == "+")
                result = a + b;
            else if (operation == "-")
                result = a - b;
            else if (operation == "*")
                result = a * b;
            else if (operation == "/")
                result = Convert.ToDouble(a) / b;

            if (result != null)
                return result;
            else
                throw new Exception("cannot calculate the result");
        }

        public double? PerformOperation(string equation) // ex: 44-56 
        {
            string[] plusArr= equation.Split('+'); //  [44-56]  (length = 1)
            string[] minusArr = equation.Split('-');  // [44] [56]  (length = 2)
            string[] multiplyArr = equation.Split('*'); //[44-56] (length = 1)
            string[] divideArr = equation.Split('/');   //[44 - 56] (length = 1)

            string operation;
            int number1;
            int number2;

            if(plusArr.Length ==2) // false
            {
                number1 = Convert.ToInt32(plusArr[0]);
                number2 = Convert.ToInt32(plusArr[1]);
                operation = "+";
            }else if(minusArr.Length ==2) // true
            {
                number1 = Convert.ToInt32(minusArr[0]);
                number2 = Convert.ToInt32(minusArr[1]);
                operation = "-";
            }
            else if (minusArr.Length == 2)  // false
            {
                number1 = Convert.ToInt32(multiplyArr[0]);
                number2 = Convert.ToInt32(multiplyArr[1]);
                operation = "*";
            }
            else  // false
            {
                number1 = Convert.ToInt32(divideArr[0]);
                number2 = Convert.ToInt32(divideArr[1]);
                operation = "/";
            }

            // string operation = equation.Substring(1, 1);
            //int number1 = Convert.ToInt32(equation.Substring(0, 1));
            //int number2 = Convert.ToInt32(equation.Substring(2));

            //double? result = null;

            //if (operation == "+")
            //    result = number1 + number2;
            //else if (operation == "-")
            //    result = number1 - number2;
            //else if (operation == "*")
            //    result = number1 * number2;
            //else if (operation == "/")
            //    result = Convert.ToDouble(number1) / number2;

            //if (result != null)
            //    return result;
            //else
            //    throw new Exception("cannot calculate the result");
            //    //return 0;
            return CalculateOperation(number1, number2, operation);
        }

    }
}
