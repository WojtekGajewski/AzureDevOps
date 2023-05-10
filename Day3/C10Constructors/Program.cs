using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "------ example 1 ------");
            Calculator calculator = 
                new Calculator("normal");

            Calculator c2 = new Calculator();

          //  calculator.Mode = "normal";
            double d= calculator.Calculate(2, 3);

            // Calculator c2 = new Calculator()

            Console.WriteLine("------ example 2 ------");

            WeatherManager weatherManager = new WeatherManager(Unit.Kelvin);
            
            weatherManager.GetTemperature("warsaw");

            weatherManager.GetTemperature("singapore");
        }
    }
}
