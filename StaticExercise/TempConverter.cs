using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        
        public static double FahrenheitToCelsius(double v) 
        {         
            return (v - 32) / 1.8000;
        }

        public static double CelsiusToFahrenheit(double v) 
        {
            return ((v * 9) / 5) + 32;
            
        }
    }
}
