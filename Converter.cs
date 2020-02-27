using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    public class Converter
    {

        public double FarenheitToCelsius(double temperature)
        {
            return (5.0 / 9.0) * (temperature - 32);
        }

        public double CelsiusToFarenheit(double temperature)
        {
            return (9.0 / 5.0) * temperature + 32;
        }

        public double AbsoluteToCelsius(double temperature)
        {
            return temperature - 273;
        }

        public double CelsiusToAbsolute(double temperature)
        {
            return temperature + 273;
        }

        public double FarenheitToAbsolute(double temperature)
        {
            return (5.0 / 9.0) * (temperature - 32) + 273;
        }

        public double AbsoluteToFarenheit(double temperature)
        {
            return (9.0 / 5.0) * (temperature - 273 )+ 32 ;
        }

    }

}