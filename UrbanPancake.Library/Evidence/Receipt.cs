namespace UrbanPancake.Library
{
    public class Receipt : IEvidence
    {
        private static string DictionaryToString(Dictionary<string, int> source, string keyValueSeparator, string sequenceSeparator)
        {
            if (source == null)
                throw new ArgumentException("Parameter source can not be null.");

            var pairs = source.Select(x => string.Format("{0}{1} {2}", x.Key, keyValueSeparator, x.Value));

            return string.Join(sequenceSeparator, pairs);
        }
        public string? TotalAmount
        {
            get; set;
        }

        public Dictionary<string, int> ItemsPurchased
        {
            get; set;
        }
        public Place? LocationFound { get; set; }
        public DateTime DateFound { get; set; }
        public string? Condition
        {
            get; set;
        }
        public string? Details { get; set; }

        public Receipt(
            Dictionary<string, int> itemsPurchased,
            string totalAmount,
            Place? locationFound = null,
            DateTime dateFound = default(DateTime),
            string? condition = null,
            string? details = null)
        {
            ItemsPurchased = itemsPurchased;
            TotalAmount = totalAmount;
            LocationFound = locationFound;
            DateFound = dateFound;
            Condition = condition;
            Details = details;
        }

        public override string ToString()
        {
            string itemsPurchasedString = DictionaryToString(ItemsPurchased, ":", ", ");
            return $"Items purchased: {itemsPurchasedString}, total: {TotalAmount}, condition: {(Condition == null ? "Unknown" : Condition)}, details: {(Details == null ? "Unknown" : Details)}, found at: {(LocationFound == null ? "Unknown" : LocationFound.Name)}, date found: {(DateFound == default(DateTime) ? "Unknown" : DateFound)}";
        }
    }
}

