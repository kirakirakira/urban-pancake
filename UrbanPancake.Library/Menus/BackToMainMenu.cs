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
            Console.WriteLine("Returning");
            return (int)MenuFunctions.ReturnToMainMenu;
        }
    }
}
