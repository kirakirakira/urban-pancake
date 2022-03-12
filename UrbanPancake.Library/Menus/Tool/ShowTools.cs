namespace UrbanPancake.Library
{
    public class ShowTools : IMenuItem
    {
        public string Choice { get; set; } = "View all tools";
        public int ExecuteChoice()
        {
            ToolRepository tools = new ToolRepository();
            Console.WriteLine(tools);
            return (int)MenuFunction.ContinueCurrentMenu;
        }
    }
}
