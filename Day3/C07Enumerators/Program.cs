using C07Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C06TaskWeather
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a city");
            string city  = Console.ReadLine();

           

            List<Unit> units = Enum.GetValues(typeof(Unit)).Cast<Unit>().ToList();

            Console.WriteLine("Enter one of the following units: " +
                string.Join(", ", units));  

            string unit = Console.ReadLine();

            bool isVaild = Enum.TryParse(unit, out Unit unitEnum);

            Unit selectedUnit = (Unit)Enum.ToObject(typeof(Unit), 2-1);

            if (isVaild)
            {
                WeatherManager weatherManager = new WeatherManager();
                double temp =  weatherManager.GetTemperature(city, unitEnum);
                Console.WriteLine(temp);
            }

           // weatherManager.GetTemperature("London", Unit.Fahrenheit);


        }
    }
}
