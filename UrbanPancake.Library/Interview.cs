namespace UrbanPancake.Library
{
    public class Interview
    {
        public Person Interviewer { get; set; }

        public Person Interviewee { get; set; }
        public DateTime Timestamp { get; set; }
        public TimeSpan Duration { get; set; }
        public string Transcript { get; set; }

        public Interview(
            Person interviewer,
            Person interviewee,
            DateTime timestamp,
            TimeSpan duration,
            string transcript
        )
        {
            Interviewer = interviewer;
            Interviewee = interviewee;
            Timestamp = timestamp;
            Duration = duration;
            Transcript = transcript;
        }

        public override string ToString()
        {
            return Interviewer.FirstName + " " + Interviewer.LastName;
        }
    }
}
