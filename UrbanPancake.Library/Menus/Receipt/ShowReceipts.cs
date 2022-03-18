namespace UrbanPancake.Library
{
    public class ShowReceipts : IMenuFunction
    {
        public string Choice { get; set; } = "View all receipts";
        public int ExecuteChoice()
        {
            ReceiptRepository receiptRepository = new ReceiptRepository();
            Console.WriteLine(receiptRepository);

            return (int)MenuFunctions.ContinueCurrentMenu;
        }
    }
}
