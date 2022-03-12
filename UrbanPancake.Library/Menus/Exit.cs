using System;
using System.Text;

namespace UrbanPancake.Library
{
    public class Exit : IMenuItem
    {
        public string Choice { get; set; } = "Exit";

        public Exit()
        {
        }

        public int ExecuteChoice()
        {
            Console.WriteLine("Type quit to quit");
            var quitString = Console.ReadLine();
            if (quitString == "quit")
            {
                Console.WriteLine("Program exited");
                return (int)MenuFunctions.ExitProgram;
            }
            else
            {
                return (int)MenuFunctions.ContinueMainMenu;
            }
        }
    }
}
