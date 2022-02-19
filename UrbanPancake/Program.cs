using System;
using UrbanPancake.Library;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace UrbanPancake
{
    class Program
    {
        static List<IMenuItem> items = new List<IMenuItem>()
        {
            new ShowPeople(),
            new Exit()
        };

        private static int GetNumber(string message = "Enter a number: ")
        {
            while (true)
            {
                Console.WriteLine(message);
                int number;
                bool validNumber = int.TryParse(Console.ReadLine(), out number);
                if (validNumber)
                    return number;
                else
                    Console.WriteLine("That was not a number, try again");
            }
        }

        private static bool ShowMenu()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Main Menu:");

            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i].Choice}");
            }

            int userChoice = GetNumber("Enter your choice: ");

            Console.WriteLine("\n");
            Console.WriteLine($"Your choice was {userChoice}");

            if (userChoice > items.Count)
            {
                Console.WriteLine("You failed to make a valid choice, too bad!");
                Console.WriteLine("Just kidding, try again");
                return false;
            }
            else
            {
                return items[userChoice - 1].ExecuteChoice();
            }
        }

        static void Main(string[] args)
        {
            var keepGoing = true;
            while (keepGoing)
            {
                keepGoing = ShowMenu();
            }
        }
    }
}
