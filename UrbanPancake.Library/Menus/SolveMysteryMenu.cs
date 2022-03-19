namespace UrbanPancake.Library
{
    public class SolveMysteryMenu : IMenuFunction
    {
        public string Choice { get; set; } = "Check if your suspect did it.";
        public int ExecuteChoice()
        {
            Console.WriteLine("Now's your chance!");
            Console.WriteLine("Who do you think did it?\n");
            Console.WriteLine("What is their first name?");
            string? firstName = Console.ReadLine();
            Console.WriteLine("What is their last name?");
            string? lastName = Console.ReadLine();
            string suspect = firstName + " " + lastName;

            string thief = System.IO.File.ReadAllText("./UrbanPancake/Secret.txt");

            if (String.Equals(suspect.Trim(), thief.Trim()))
            {
                Console.WriteLine("You figured it out. Aren't you a smartie.\n");
            }
            else
            {
                Console.WriteLine("Sorry, you can go back and review the research and try again.\n");
            }

            return (int)MenuFunctions.ContinueCurrentMenu;
        }
    }
}
