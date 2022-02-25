namespace UrbanPancake.Library
{
    public class CreditCardTransaction
    {
        public string Store { get; set; }
        public decimal Amount { get; set; }
        public string CreditCardNumber { get; set; }
        public CreditCardTransaction(string store, decimal amount, string creditCardNumber)
        {
            Store = store;
            Amount = amount;
            CreditCardNumber = creditCardNumber;
        }
    }
}
