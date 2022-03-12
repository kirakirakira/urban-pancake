using System.Text.Json;

namespace UrbanPancake.Library
{
    public class PeopleMenu : IMenuItem
    {
        private static List<IMenuItem> items = new List<IMenuItem>()
        {
            new ShowPeople(),
            new SearchPeople(),
            new BackToMainMenu()
        };
        public string Choice { get; set; } = "People Menu. Make a selection.";

        private static int ShowMenu()
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i].Choice}");
            }

            int userChoice = MenuMethods.GetNumber("Enter your choice: ");

            Console.WriteLine("\n");
            Console.WriteLine($"Your choice was {userChoice}");
            Console.WriteLine("\n");

            if (userChoice > items.Count)
            {
                Console.WriteLine("You failed to make a valid choice, try again!");
                return (int)MenuFunctions.ContinueCurrentMenu;
            }
            else
            {
                return items[userChoice - 1].ExecuteChoice();
            }
        }

        public int ExecuteChoice()
        {
            var keepGoing = (int)MenuFunctions.ContinueCurrentMenu;
            while (keepGoing == (int)MenuFunctions.ContinueCurrentMenu)
            {
                keepGoing = ShowMenu();
            }
            return (int)MenuFunctions.ContinueMainMenu;
        }
    }
}
