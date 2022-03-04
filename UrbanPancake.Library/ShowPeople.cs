using System.Text.Json;

namespace UrbanPancake.Library
{
    public class ShowPeople : IMenuItem
    {
        public string Choice { get; set; } = "View all people";
        public int ExecuteChoice()
        {
            PersonRepository people = new PersonRepository();
            var persons = JsonSerializer.Deserialize<List<Person>>(File.ReadAllText(@"UrbanPancake/Data/PersonData.json"));

            for (int i = 0; i < persons?.Count; i++)
            {
                persons[i].DisplayDetails();
                people.Add(persons[i]);
            }

            Console.WriteLine(people);

            return 1;
        }
    }
}
