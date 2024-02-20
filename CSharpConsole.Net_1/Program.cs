using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number: ");
        if (double.TryParse(Console.ReadLine(), out double value))
        {
            Console.Write("Enter the percentage: ");
            if (double.TryParse(Console.ReadLine(), out double percentage))
            {
                double result = CalculatePercentage(value, percentage);
                Console.WriteLine($"{percentage}% of {value} is: {result}");
            }
            else
            {
                Console.WriteLine("Invalid input for percentage. Please enter a valid number");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for value. Please enter a valid number");
        }
    }

    static double CalculatePercentage(double value, double percentage)
    {
        return (percentage / 100) * value;
    }
}
