namespace UrbanPancake.Library
{
    public class PhoneCall
    {
        public string OriginPhoneNumber { get; set; }
        public string RecipientPhoneNumber { get; set; }
        public DateTime Timestamp { get; set; }
        public TimeSpan Duration { get; set; }
        public PhoneCall(
            string originPhoneNumber,
            string recipientPhoneNumber,
            DateTime timestamp,
            TimeSpan duration)
        {
            OriginPhoneNumber = originPhoneNumber;
            RecipientPhoneNumber = recipientPhoneNumber;
            Timestamp = timestamp;
            Duration = duration;
        }
    }
}
