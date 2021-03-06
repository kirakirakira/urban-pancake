namespace UrbanPancake.Library
{
    public class SurveillanceFootage : IVideo
    {
        public TimeSpan Duration { get; set; }
        public Place Location { get; set; }
        public DateTime Timestamp { get; set; }
        public Person Author { get; set; }
        public List<string> ImageRecognition { get; set; }

        public SurveillanceFootage(
            TimeSpan duration,
            Place location,
            DateTime timestamp,
            Person author,
            List<string> imageRecognition)
        {
            Duration = duration;
            Location = location;
            Timestamp = timestamp;
            Author = author;
            ImageRecognition = imageRecognition;
        }
    }
}
