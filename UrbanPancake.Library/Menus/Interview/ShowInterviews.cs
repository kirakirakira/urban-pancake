namespace UrbanPancake.Library
{
    public class ShowInterviews : IMenuFunction
    {
        public string Choice { get; set; } = "View all interviews";
        public int ExecuteChoice()
        {
            InterviewRepository interviews = new InterviewRepository();
            Console.WriteLine(interviews);
            return (int)MenuFunctions.ContinueCurrentMenu;
        }
    }
}
