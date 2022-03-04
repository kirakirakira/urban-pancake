namespace UrbanPancake.Library
{
    public class MainMenu : IMenuItem
    {
        private static List<IMenuItem> items = new List<IMenuItem>()
        {
            new PeopleMenu(),
            new Exit()
        };
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
                return (int)MenuFunction.One;
            }
            else
            {
                return items[userChoice - 1].ExecuteChoice();
            }
        }

        public int ExecuteChoice()
        {
            var keepGoing = (int)MenuFunction.Two;
            while (keepGoing == (int)MenuFunction.Two)
            {
                keepGoing = ShowMenu();
            }
            return (int)MenuFunction.Four;
        }
    }
}
