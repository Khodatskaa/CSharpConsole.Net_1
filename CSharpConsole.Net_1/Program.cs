using System;

namespace CSharpConsole.Net_1
{
    class Program
    {
        static void Main() {
            Console.WriteLine("Enter a number in range from 1 to 100: ");
            if (int.TryParse(Console.ReadLine(), out int userInput) && userInput >= 1 && userInput <= 100) {
                FizzBuzz(userInput);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 100");
            }
        }

        static void FizzBuzz (int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }
    }
}