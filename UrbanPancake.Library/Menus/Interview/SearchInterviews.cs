using System.Text.Json;

namespace UrbanPancake.Library
{
    public class SearchInterviews : IMenuItem
    {
        public string Choice { get; set; } = "Search for a specific interview";
        public int ExecuteChoice()
        {
            Console.WriteLine("Who's interview do you want to view?");
            Console.WriteLine("What is the interviewee's first name?");
            string? firstName = Console.ReadLine();
            Console.WriteLine("What is the interviewee's last name?");
            string? lastName = Console.ReadLine();

            InterviewRepository interviews = new InterviewRepository();
            if (firstName != null && lastName != null)
            {
                Interview? found = interviews.FindInterviewWith(firstName, lastName);
                if (found != null)
                {
                    Console.WriteLine("\n" + found);
                }
                else
                {
                    Console.WriteLine("\n" + "Interview doesn't exist." + "\n");
                }
            }

            return (int)MenuFunctions.ContinueCurrentMenu;
        }
    }
}
