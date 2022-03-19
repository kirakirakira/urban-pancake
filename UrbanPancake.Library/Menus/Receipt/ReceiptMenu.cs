namespace UrbanPancake.Library
{
    public class ReceiptMenu : IMenuFunction
    {
        private static List<IMenuFunction> items = new List<IMenuFunction>()
        {
            new ShowReceipts(),
            new SearchReceipts(),
            new BackToMainMenu()
        };

        public List<IMenuFunction> GetItems()
        {
            return items;
        }

        public string Choice { get; set; } = "To view receipts that have been found near the scene of the crime.";
    }
}
