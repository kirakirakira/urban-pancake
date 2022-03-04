using System.Text.Json;

namespace UrbanPancake.Library
{
    public class SearchPeople : IMenuItem
    {
        public string Choice { get; set; } = "Search for a specific person";
        public int ExecuteChoice()
        {
            // PersonRepository people = new PersonRepository();
            // var persons = JsonSerializer.Deserialize<List<Person>>(File.ReadAllText(@"UrbanPancake/Data/PersonData.json"));

            // for (int i = 0; i < persons?.Count; i++)
            // {
            //     persons[i].DisplayDetails();
            //     people.Add(persons[i]);
            // }

            // Console.WriteLine(people);
            Console.WriteLine("Search people here");
            return 1;
        }
    }
}
