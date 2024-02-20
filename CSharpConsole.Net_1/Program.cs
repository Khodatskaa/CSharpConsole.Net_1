using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the value of A (A < B): ");
        if (int.TryParse(Console.ReadLine(), out int a))   // out int a - declare a variable to store the parsed value
        {
            Console.Write("Enter the value of B: ");
            if (int.TryParse(Console.ReadLine(), out int b) && b > a)     // out int b - declare a variable to store the parsed value
            {
                DisplayNumberTriangle(a, b);
            }
            else
            {
                Console.WriteLine("Invalid input for B. Enter a valid integer greater than A");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for A. Enter a valid integer");
        }
    }

    static void DisplayNumberTriangle(int a, int b)
    {
        for (int i = a; i <= b; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine(); 
        }
    }
}
