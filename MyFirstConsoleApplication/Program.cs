using System;
using System.Security.Cryptography;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main()
        {
            string name, location;
            name = "Kylar Sorensen";
            location = "Yakima, WA, USA";
            Console.WriteLine($"My name is {name}, I am from {location}.");

            DateTime currentDate = DateTime.Now;
            Console.WriteLine($"The current date is {currentDate.ToString("MM/dd/yyyy")}.");

            DateTime christmas = new DateTime(2023, 12, 25);
            int daysUntilChristmas = (christmas - currentDate).Days;
            Console.WriteLine($"There are {daysUntilChristmas} days until Christmas.");

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Please enter the width of the window in feet.");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Please enter the height of the window in feet.");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
                woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
                glassArea + " square metres");

            Console.ReadKey();
        }
    }
}
