using System.Text.Json;

namespace UrbanPancake.Library
{
    public class ShowPeople : IMenuItem
    {
        public string Choice { get; set; } = "View all people";
        public bool ExecuteChoice()
        {
            PersonRepository people = new PersonRepository();
            var persons = JsonSerializer.Deserialize<List<Person>>(File.ReadAllText(@"UrbanPancake/PersonData.json"));

            for (int i = 0; i < persons?.Count; i++)
            {
                people.Add(persons[i]);
            }

            Console.WriteLine(people);

            return true;
        }
    }
}
