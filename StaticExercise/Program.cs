using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("This is a temperature converter program.");
            Console.WriteLine("If you need to convert Fahrenheit to Celsius please enter 1.");
            Console.WriteLine("If you need to convert Celsius to Fahrenheit please enter 2:");
            Start:
            int selector;
            string input = Console.ReadLine();
            bool isString = int.TryParse(input, out selector);

            if (selector == 1)
            {
                Console.WriteLine("Please input your temperature in Fahrenheit:");
                double v = Convert.ToDouble(Console.ReadLine());
                double cel = TempConverter.FahrenheitToCelsius(v);
                Console.WriteLine($"Your temperature in Celsius is {cel} degrees.");
                return;
            }
            else if (selector == 2)
            {
                Console.WriteLine("Please input your temperature in Celsius:");
                double v = Convert.ToDouble(Console.ReadLine());
                double fah = TempConverter.CelsiusToFahrenheit(v);
                Console.WriteLine($"Your temperature in Fahrenheit is {fah} degrees.");
                return;
            }
            else
            {
                Console.WriteLine($"You used an invalid input, please input a 1 or 2:");
                goto Start;
            }
            
            
            
        }
    }
}
