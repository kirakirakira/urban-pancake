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
            return $"type: {Type}, condition: {(Condition == null ? "Unknown" : Condition)}, details: {(Details == null ? "Unknown" : Details)}, found at: {(LocationFound == null ? "Unknown" : LocationFound)}, date found: {(DateFound == default(DateTime) ? "Unknown" : DateFound)}";
        }
    }
}

