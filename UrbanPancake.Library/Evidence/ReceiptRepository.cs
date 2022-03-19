using System.Text;
using System.Text.Json;

namespace UrbanPancake.Library
{
    public class ReceiptRepository : IRepository<Receipt>
    {
        private readonly List<Receipt> _allReceipts = new List<Receipt>();

        public void Add(Receipt receipt)
        {
            _allReceipts.Add(receipt);
        }

        public IEnumerable<Receipt> GetAllItems()
        {
            return _allReceipts;
        }
        public Receipt? FindReceiptWithItemPurchased(string item)
        {
            Receipt? foundReceipt;
            try
            {
                foundReceipt = _allReceipts.Find(receipt => receipt.ItemsPurchased.ContainsKey(item));
                return foundReceipt;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public ReceiptRepository()
        {
            var receipts = JsonSerializer.Deserialize<List<Receipt>>(File.ReadAllText(@"UrbanPancake/Data/ReceiptData.json"));

            for (int i = 0; i < receipts?.Count; i++)
            {
                _allReceipts.Add(receipts[i]);
            }
        }
    }
}
