namespace UrbanPancake.Library
{
    public class SocialMedia : IVideo
    {
        public TimeSpan Duration { get; set; }
        public Place Location { get; set; }
        public DateTime Timestamp { get; set; }
        public Person Author { get; set; }

        public List<string> Tags { get; set; }
        public string Platform { get; set; }
        public string AccountName { get; set; }

        public SocialMedia(
            TimeSpan duration,
            Place location,
            DateTime timestamp,
            Person author,
            List<string> tags,
            string platform,
            string accountName)
        {
            Duration = duration;
            Location = location;
            Timestamp = timestamp;
            Author = author;
            Tags = tags;
            Platform = platform;
            AccountName = accountName;
        }
    }
}
