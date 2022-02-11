namespace UrbanPancake.Library
{
    public interface IEvidence
    {
        DateTime DateFound { get; set; }

        string? LocationFound { get; set; }

        string? Condition { get; set; }

        string? Details { get; set; }
    }
}
