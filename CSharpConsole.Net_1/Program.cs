using System;

class Program
{
    static void Main()
    {
        double[] numbers = new double[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            if (double.TryParse(Console.ReadLine(), out double userInput))          // TryParse returns true if the input is a valid number
            {
                numbers[i] = userInput;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number");
                i--;
            }
        }

        double sum = 0;
        double max = numbers[0];
        double min = numbers[0];
        double product = 1;

        foreach (double num in numbers)
        {
            sum += num;
            if (num > max) max = num;
            if (num < min) min = num;
            product *= num;
        }

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Maximum: {max}");
        Console.WriteLine($"Minimum: {min}");
        Console.WriteLine($"Product: {product}");
    }
}
