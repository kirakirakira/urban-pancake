using System.Text.Json;

namespace UrbanPancake.Library
{
    public class InterviewMenu : IMenuFunction
    {
        private static List<IMenuFunction> items = new List<IMenuFunction>()
        {
            new ShowInterviews(),
            new SearchInterviews(),
            new BackToMainMenu()
        };

        public List<IMenuFunction> GetItems()
        {
            return items;
        }

        public string Choice { get; set; } = "Interview Menu. Make a selection.";
    }
}
