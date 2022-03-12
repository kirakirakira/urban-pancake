namespace UrbanPancake.Library
{
    public class ViewPeople : IMenuItem
    {
        public string Choice { get; set; } = "View people";

        public ViewPeople(
            string choice
        )
        {
            Choice = choice;
        }
        public int ExecuteChoice()
        {
            return (int)MenuFunctions.ContinueCurrentMenu;
        }
    }
}
