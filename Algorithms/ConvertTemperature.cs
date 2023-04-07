using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDSA.Algorithm
{
    internal class ConvertTemperature
    {
        private const double _times = 1.8;
        private const double _formulaNumber = 32;
        public static double CelsiusToFarenheit(double temperature)
        {
            return (temperature*_times +_formulaNumber);
        }

        public static double FarenheitToCelsius(double temperature)
        {
            return ((temperature - _formulaNumber) / _times);
        }

    }
}
