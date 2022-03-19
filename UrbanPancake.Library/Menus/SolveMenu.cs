namespace UrbanPancake.Library
{
    public class SolveMenu : IMenuFunction
    {
        private static List<IMenuFunction> items = new List<IMenuFunction>()
        {
            new SolveMysteryMenu(),
            new BackToMainMenu()
        };

        public List<IMenuFunction> GetItems()
        {
            return items;
        }

        public string Choice { get; set; } = "Solve the mystery.";
    }
}
