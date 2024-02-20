using System;

namespace CSharpConsole.Net_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice) && (choice == 1 || choice == 2))
            {
                Console.Write("Enter the temperature: ");
                if (double.TryParse(Console.ReadLine(), out double temperature))
                {
                    double convertedTemperature = (choice == 1) ? FahrenheitToCelsius(temperature) : CelsiusToFahrenheit(temperature);
                    Console.WriteLine($"Converted temperature: {convertedTemperature}");
                }
                else
                {
                    Console.WriteLine("Invalid temperature input. Please enter a valid number");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 1 or 2");
            }
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}