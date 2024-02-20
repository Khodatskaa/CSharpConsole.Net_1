using System;

namespace CSharpConsole.Net_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the date(dd.mm.yyyy): ");
            if (DateTime.TryParseExact(Console.ReadLine(), "dd.mm.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime inputDate))
            {
                string season = GetSeason(inputDate.Month);
                string dayOfWeek = inputDate.DayOfWeek.ToString();

                Console.WriteLine($"{season} {dayOfWeek}");
            }
            else
            {
                Console.WriteLine("Invalid date format. Please enter a valid date in the format DD.MM.YYYY");
            }
        }

        static string GetSeason(int month)
        {
            if (month == 12 || month == 1 || month == 2)
            {
                return "Winter";
            }
            else if (month >= 3 && month <= 5)
            {
                return "Spring";
            }
            else if (month >= 6 && month <= 8)
            {
                return "Summer";
            }
            else
            {
                return "Autumn";
            }
        }
    }
}