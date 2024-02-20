using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        if (int.TryParse(Console.ReadLine(), out int number1))
        {
            Console.Write("Enter the second number: ");
            if (int.TryParse(Console.ReadLine(), out int number2))
            {
                NormalizeRange(ref number1, ref number2);

                Console.WriteLine($"Even numbers in the range {number1} to {number2}:");
                DisplayEvenNumbersInRange(number1, number2);
            }
            else
            {
                Console.WriteLine("Invalid input for the second number. Please enter a valid integer");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for the first number. Please enter a valid integer");
        }
    }

    static void NormalizeRange(ref int number1, ref int number2)
    {
        if (number1 > number2)
        {
            int temp = number1;
            number1 = number2;
            number2 = temp;
        }
    }

    static void DisplayEvenNumbersInRange(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
