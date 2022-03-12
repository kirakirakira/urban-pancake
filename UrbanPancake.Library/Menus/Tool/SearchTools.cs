using System.Text.Json;

namespace UrbanPancake.Library
{
    public class SearchTools : IMenuFunction
    {
        public string Choice { get; set; } = "Search for a specific tool";
        public int ExecuteChoice()
        {
            Console.WriteLine("What type of tool are you looking for");
            string? type = Console.ReadLine();

            ToolRepository tools = new ToolRepository();
            if (type != null)
            {
                Tool? found = tools.FindToolWithType(type);
                if (found != null)
                {
                    Console.WriteLine("\n" + found);
                }
                else
                {
                    Console.WriteLine("\n" + "Tool doesn't exist." + "\n");
                }
            }

            return (int)MenuFunctions.ContinueCurrentMenu;
        }
    }
}
