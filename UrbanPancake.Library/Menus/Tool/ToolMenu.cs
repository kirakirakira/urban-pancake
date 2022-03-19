using System.Text.Json;

namespace UrbanPancake.Library
{
    public class ToolMenu : IMenuFunction
    {
        private static List<IMenuFunction> items = new List<IMenuFunction>()
        {
            new ShowTools(),
            new SearchTools(),
            new BackToMainMenu()
        };

        public List<IMenuFunction> GetItems()
        {
            return items;
        }

        public string Choice { get; set; } = "To view other pieces of evidence found.";
    }
}
