using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08PropertiesAndFields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.FirstName = "John";
            
            // we use setter
            person.LastName = "Smith";

            //we use getter 
            Console.WriteLine(person.LastName);

            Console.WriteLine(person.FullName);
      
        
            WeatherManager weatherManager = new WeatherManager();

            Console.WriteLine(weatherManager.SearchChar);
            //weatherManager.SearchChar = "x";

            weatherManager.EndChar = "%";



            weatherManager.GetTemperature("Warsaw", Unit.Celsius);

        }
    }
}
