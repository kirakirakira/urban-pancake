using System.Text;
using System.Text.Json;

namespace UrbanPancake.Library
{
    public class InterviewRepository
    {
        private readonly List<Interview> _allInterviews = new List<Interview>();

        public void Add(Interview interview)
        {
            _allInterviews.Add(interview);
        }

        public Interview? FindInterviewWith(string first, string last)
        {
            Interview? foundInterview;
            try
            {
                foundInterview = _allInterviews.Find(interview => interview.Interviewee.FirstName == first && interview.Interviewee.LastName == last);
                return foundInterview;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (_allInterviews.Count != 0)
            {
                sb.Append("The interviews in the repository are: \n");
                foreach (Interview? interview in _allInterviews)
                {
                    sb.Append(interview.ToString() + "\n");
                }
            }
            else
            {
                sb.Append("There are no interviews in the repository.");
            }

            return sb.ToString();
        }

        public InterviewRepository()
        {
            var interviews = JsonSerializer.Deserialize<List<Interview>>(File.ReadAllText(@"UrbanPancake/Data/InterviewData.json"));

            for (int i = 0; i < interviews?.Count; i++)
            {
                _allInterviews.Add(interviews[i]);
            }
        }
    }
}
