using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{

    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Write the Farenheit temperature:");
            string temperature1 = Console.ReadLine();

            var converter1 = new Converter();
            double result1 = converter1.FarenheitToCelsius(Convert.ToDouble(temperature1));

            Console.WriteLine(String.Format("The temperature in Celsius is {0}", result1));
            Console.ReadLine();

            var converter2 = new Converter();
            double result2 = converter1.FarenheitToAbsolute(Convert.ToDouble(temperature1));

            Console.WriteLine(String.Format("The temperature in Absolute is {0}", result2));
            Console.ReadLine();


            Console.WriteLine("Write the Celsius temperature:");
            string temperature2 = Console.ReadLine();

            var converter3 = new Converter();
            double result3 = converter3.CelsiusToFarenheit(Convert.ToDouble(temperature2));

            Console.WriteLine(String.Format("The temperature in Farenheit is {0}", result3));
            Console.ReadLine();

            var converter4 = new Converter();
            double result4 = converter1.CelsiusToAbsolute(Convert.ToDouble(temperature2));

            Console.WriteLine(String.Format("The temperature in Absolute is {0}", result4));
            Console.ReadLine();


            Console.WriteLine("Write the Absolute temperature:");
            string temperature3 = Console.ReadLine();

            var converter5 = new Converter();
            double result5 = converter3.AbsoluteToCelsius(Convert.ToDouble(temperature3));

            Console.WriteLine(String.Format("The temperature in Celsius is {0}", result5));
            Console.ReadLine();

            var converter6 = new Converter();
            double result6 = converter1.AbsoluteToFarenheit(Convert.ToDouble(temperature3));

            Console.WriteLine(String.Format("The temperature in Farenheit is {0}", result6));
            Console.ReadLine();
        }
    }
}