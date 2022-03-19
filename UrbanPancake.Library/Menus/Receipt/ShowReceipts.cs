namespace UrbanPancake.Library
{
    public class ShowReceipts : IMenuFunction
    {
        public string Choice { get; set; } = "View all receipts";
        public int ExecuteChoice()
        {
            ReceiptRepository receiptRepository = new ReceiptRepository();
            IEnumerable<Receipt> receipts = receiptRepository.GetAllItems();
            foreach (Receipt receipt in receipts)
            {
                Console.WriteLine(receipt + "\n");
            }
            return (int)MenuFunctions.ContinueCurrentMenu;
        }
    }
}
