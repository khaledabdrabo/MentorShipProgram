using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    public class VariableInitialization
    {
        public double temCelsius;
        public double temFahrenheit;

        public void InitializeTemperatureVariables()
        {
            temCelsius = 0;
            temFahrenheit = 32;
        }
        public void DisplayTemperature()
        {
            Console.WriteLine($"The Temperature with Celsius:{temCelsius}");
            Console.WriteLine($"The Temperature with Fahrenheit:{temFahrenheit}");
        }

    }

}
