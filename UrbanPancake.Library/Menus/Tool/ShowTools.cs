namespace UrbanPancake.Library
{
    public class ShowTools : IMenuFunction
    {
        public string Choice { get; set; } = "View all tools";
        public int ExecuteChoice()
        {
            ToolRepository tools = new ToolRepository();
            Console.WriteLine(tools);
            return (int)MenuFunctions.ContinueCurrentMenu;
        }
    }
}
