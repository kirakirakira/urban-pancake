using System.Text;
using System.Text.Json;

namespace UrbanPancake.Library
{
    public class ReceiptRepository
    {
        private readonly List<Receipt> _allReceipts = new List<Receipt>();

        public void Add(Receipt receipt)
        {
            _allReceipts.Add(receipt);
        }

        // public Receipt? FindReceiptWithItemPurchased(string item)
        // {
        //     Receipt? foundReceipt;
        //     try
        //     {
        //         foundReceipt = _allReceipts.Find(receipt => receipt.ItemsPurchased.ContainsKey(item));
        //         return foundReceipt;
        //     }
        //     catch (Exception e)
        //     {
        //         Console.WriteLine(e);
        //         return null;
        //     }
        // }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (_allReceipts.Count != 0)
            {
                sb.Append("The tools in the repository are: \n");
                foreach (Receipt? receipt in _allReceipts)
                {
                    sb.Append(receipt.ToString() + "\n");
                }
            }
            else
            {
                sb.Append("There are no receipts in the repository.");
            }

            return sb.ToString();
        }

        public ReceiptRepository()
        {
            var receipts = JsonSerializer.Deserialize<List<Receipt>>(File.ReadAllText(@"UrbanPancake/Data/ReceiptData.json"));

            for (int i = 0; i < receipts?.Count; i++)
            {
                Console.WriteLine(receipts[i]);
                _allReceipts.Add(receipts[i]);
            }
        }
    }
}
