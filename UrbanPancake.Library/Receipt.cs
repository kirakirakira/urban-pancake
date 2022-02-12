namespace UrbanPancake.Library
{
    public class Receipt : IEvidence
    {
        public decimal? TotalAmount
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
            decimal totalAmount,
            Dictionary<string, int> itemsPurchased,
            Place? locationFound = null,
            DateTime dateFound = default(DateTime),
            string? condition = null,
            string? details = null)
        {
            TotalAmount = totalAmount;
            ItemsPurchased = itemsPurchased;
            LocationFound = locationFound;
            DateFound = dateFound;
            Condition = condition;
            Details = details;
        }

        // public override string ToString()
        // {
        //     return $"type: {Type}, condition: {(Condition == null ? "Unknown" : Condition)}, details: {(Details == null ? "Unknown" : Details)}, found at: {(LocationFound == null ? "Unknown" : LocationFound)}, date found: {(DateFound == default(DateTime) ? "Unknown" : DateFound)}";
        // }
    }
}

