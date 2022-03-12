namespace UrbanPancake.Library
{
    public interface IVideo
    {
        TimeSpan Duration { get; set; }

        Place Location { get; set; }

        DateTime Timestamp { get; set; }

        Person Author { get; set; }
    }
}
