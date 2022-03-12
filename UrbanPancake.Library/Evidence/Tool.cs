namespace UrbanPancake.Library
{
    public class Tool : IEvidence
    {
        public string? Type
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

        public Tool(
            string type,
            Place? locationFound = null,
            DateTime dateFound = default(DateTime),
            string? condition = null,
            string? details = null)
        {
            Type = type;
            LocationFound = locationFound;
            DateFound = dateFound;
            Condition = condition;
            Details = details;
        }

        public override string ToString()
        {
            return $"type: {Type}\ncondition: {(Condition == null ? "Unknown" : Condition)}\ndetails: {(Details == null ? "Unknown" : Details)}\nfound at: {(LocationFound == null ? "Unknown" : LocationFound)}\ndate found: {(DateFound == default(DateTime) ? "Unknown" : DateFound)}\n";
        }
    }
}

