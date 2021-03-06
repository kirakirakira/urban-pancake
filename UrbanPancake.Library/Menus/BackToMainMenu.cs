using System;
using System.Text;

namespace UrbanPancake.Library
{
    public class BackToMainMenu : IMenuFunction
    {
        public string Choice { get; set; } = "Back to main menu";

        public BackToMainMenu()
        {
        }

        public int ExecuteChoice()
        {
            Console.WriteLine("Main Menu");
            return (int)MenuFunctions.ReturnToMainMenu;
        }
    }
}
