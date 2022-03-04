using System.Text.Json;

namespace UrbanPancake.Library
{
    public class SearchPeople : IMenuItem
    {
        public string Choice { get; set; } = "Search for a specific person";
        public int ExecuteChoice()
        {
            Console.WriteLine("Search people here");
            return (int)MenuFunction.One;
        }
    }
}
