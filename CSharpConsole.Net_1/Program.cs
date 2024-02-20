using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a six-digit number: ");
        if (int.TryParse(Console.ReadLine(), out int number) && IsSixDigitNumber(number))
        {
            Console.Write("Enter the positions of the digits to replace (1-6): ");
            if (TryParsePositions(Console.ReadLine(), out int position1, out int position2))
            {
                int result = ReplaceDigits(number, position1, position2);
                Console.WriteLine($"The modified number is: {result}");
            }
            else
            {
                Console.WriteLine("Invalid input for positions. Please enter two positions between 1 and 6 separated by space");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a six-digit number");
        }
    }

    static bool IsSixDigitNumber(int number)
    {
        return number >= 100000 && number <= 999999;
    }

    static bool TryParsePositions(string input, out int position1, out int position2)
    {
        position1 = 0;
        position2 = 0;

        string[] positions = input.Trim().Split(' ');

        if (positions.Length != 2)
        {
            return false;
        }

        if (!int.TryParse(positions[0], out position1) || !int.TryParse(positions[1], out position2))
        {
            return false;
        }

        return position1 >= 1 && position1 <= 6 && position2 >= 1 && position2 <= 6;
    }

    static int ReplaceDigits(int number, int position1, int position2)
    {
        int[] digits = new int[6];
        int temp = number;

        for (int i = 5; i >= 0; i--)
        {
            digits[i] = temp % 10;
            temp /= 10;
        }

        int tempDigit = digits[position1 - 1];
        digits[position1 - 1] = digits[position2 - 1];
        digits[position2 - 1] = tempDigit;

        int result = 0;
        for (int i = 0; i < 6; i++)
        {
            result = result * 10 + digits[i];
        }

        return result;
    }
}
