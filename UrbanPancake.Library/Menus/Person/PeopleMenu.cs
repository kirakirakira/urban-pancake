using System.Text.Json;

namespace UrbanPancake.Library
{
    public class PeopleMenu : IMenuFunction
    {
        private static List<IMenuFunction> items = new List<IMenuFunction>()
        {
            new ShowPeople(),
            new SearchPeople(),
            new BackToMainMenu()
        };

        public List<IMenuFunction> GetItems()
        {
            return items;
        }

        public string Choice { get; set; } = "People Menu. Make a selection.";
    }
}
