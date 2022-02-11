namespace UrbanPancake.Library
{
    public class Tool : IEvidence
    {
        public string? Type
        {
            get; set;
        }
        public string? LocationFound { get; set; }
        public DateTime DateFound { get; set; }
        public string? Condition
        {
            get; set;
        }
        public string? Details { get; set; }

        public Tool(
            string type,
            string? locationFound = null,
            DateTime dateFound = default(DateTime),
            string? condition = null,
            string? details = null)
        {
            // if (!dateFound.HasValue)
            // {
            //     dateFound = DateTime.Now;
            // }

            Type = type;
            LocationFound = locationFound;
            DateFound = dateFound;
            Condition = condition;
            Details = details;
        }



        // public override string ToString()
        // {
        // }
    }
}

