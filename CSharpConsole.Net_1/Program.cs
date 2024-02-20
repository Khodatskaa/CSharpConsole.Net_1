using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the lower limit of the range: ");
        if (int.TryParse(Console.ReadLine(), out int lowerLimit))   
        {
            Console.Write("Enter the upper limit of the range: ");
            if (int.TryParse(Console.ReadLine(), out int upperLimit) && upperLimit >= lowerLimit)
            {
                DisplayFibonacciInRange(lowerLimit, upperLimit);
            }
            else
            {
                Console.WriteLine("Invalid upper limit. Please enter a valid integer greater or equal to the lower limit");
            }
        }
        else
        {
            Console.WriteLine("Invalid lower limit. Please enter a valid integer");
        }
    }

    static void DisplayFibonacciInRange(int lowerLimit, int upperLimit)
    {
        int a = 0, b = 1, c = 0;

        while (c <= upperLimit)
        {
            if (c >= lowerLimit)
            {
                Console.Write($"{c} ");      //($"{c} ") is used to display the value of c followed by a space
            }

            a = b;
            b = c;
            c = a + b;
        }

        Console.WriteLine(); 
    }
}
