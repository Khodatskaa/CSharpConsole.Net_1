using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter four digits:");

        int[] digits = new int[4];

        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Digit {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int digit) && digit >= 0 && digit <= 9)
            {
                digits[i] = digit;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a digit between 0 and 9");
                i--; 
            }
        }

        int number = ConstructNumber(digits);
        Console.WriteLine($"The number constructed from the digits is: {number}");
    }

    static int ConstructNumber(int[] digits)
    {
        int number = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            number = number * 10 + digits[i];
        }
        return number;
    }
}
