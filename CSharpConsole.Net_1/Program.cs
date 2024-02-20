using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the line length: ");
        if (int.TryParse(Console.ReadLine(), out int length) && length > 0)
        {
            Console.Write("Enter the symbol placeholder: ");
            char placeholder = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Move to the next line after reading the symbol

            Console.Write("Enter the line direction (h for horizontal, v for vertical): ");
            char direction = Console.ReadKey().KeyChar;
            Console.WriteLine();  // Move to the next line after reading the direction

            if (direction == 'h' || direction == 'H')
            {
                DisplayHorizontalLine(length, placeholder);
            }
            else if (direction == 'v' || direction == 'V')
            {
                DisplayVerticalLine(length, placeholder);
            }
            else
            {
                Console.WriteLine("Invalid direction. Enter 'h' for horizontal or 'v' for vertical");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for line length. Enter a valid positive integer");
        }
    }

    static void DisplayHorizontalLine(int length, char placeholder)
    {
        for (int i = 0; i < length; i++)
        {
            Console.Write($"{placeholder} ");
        }
        Console.WriteLine(); 
    }

    static void DisplayVerticalLine(int length, char placeholder)
    {
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(placeholder);    // will move to the next line after displaying the character
        }
    }
}
