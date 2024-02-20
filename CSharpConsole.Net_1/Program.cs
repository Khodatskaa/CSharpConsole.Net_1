using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a six-digit number: ");
        if (int.TryParse(Console.ReadLine(), out int userInput) && userInput >= 100000 && userInput <= 999999)
        {
            int reversedNumber = ReverseNumber(userInput);
            Console.WriteLine($"Reversed number: {reversedNumber}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid six-digit number");
        }
    }

    static int ReverseNumber(int number)
    {
        int reversedNumber = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number /= 10;
        }

        return reversedNumber;
    }
}
