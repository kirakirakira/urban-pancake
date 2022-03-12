namespace UrbanPancake.Library
{
    public interface IMenuFunction : IMenuItem
    {
        public List<IMenuFunction> GetItems()
        {
            return new List<IMenuFunction>();
        }
        private int ShowMenu()
        {
            List<IMenuFunction> items = this.GetItems();

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
