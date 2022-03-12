namespace UrbanPancake.Library
{
    public class MainMenu
    {
        private static List<IMenuFunction> items = new List<IMenuFunction>()
        {
            new PeopleMenu(),
            new InterviewMenu(),
            new ToolMenu(),
            new Exit()
        };

        public List<IMenuFunction> GetItems()
        {
            return items;
        }

        public string Choice { get; set; } = "Main Menu. Make a selection.";

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
            var keepGoing = (int)MenuFunctions.ContinueMainMenu;
            while (keepGoing == (int)MenuFunctions.ContinueMainMenu)
            {
                keepGoing = ShowMenu();
            }
            return (int)MenuFunctions.ExitProgram;
        }
    }
}
