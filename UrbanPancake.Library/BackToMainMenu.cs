using System;
using System.Text;

namespace UrbanPancake.Library
{
    public class BackToMainMenu : IMenuItem
    {
        public string Choice { get; set; } = "Back to main menu";

        public BackToMainMenu()
        {
        }

        public int ExecuteChoice()
        {
            Console.WriteLine("Type back to go back to the main menu");
            var backString = Console.ReadLine();
            if (backString == "back")
            {
                Console.WriteLine("Returning");
                return (int)MenuFunction.Three;
            }
            else
            {
                return (int)MenuFunction.One;
            }
        }
    }
}
