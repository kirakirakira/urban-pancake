namespace UrbanPancake.Library
{
    public interface IEvidenceTest
    {
        DateTime DateFound { get; set; }

        string LocationFound { get; set; }

        string Condition();

        string Details();
    }
}
