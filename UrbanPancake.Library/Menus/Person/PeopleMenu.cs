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

        public string Choice { get; set; } = "To learn about various suspects.";
    }
}
