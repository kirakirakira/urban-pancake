using System;
using UrbanPancake.Library;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace UrbanPancake
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonRepository people = new PersonRepository();
            var persons = JsonSerializer.Deserialize<List<Person>>(File.ReadAllText(@"UrbanPancake/PersonData.json"));

            for (int i = 0; i < persons?.Count; i++)
            {
                people.Add(persons[i]);
            }

            Person? foundPerson = people.FindPersonWith("Katarina", "Bubbles");
            if (foundPerson == null)
            {
                Console.WriteLine("There's no person with that name");
            }
            Console.WriteLine(foundPerson?.PhoneNumber);
            if (foundPerson?.PhoneNumber == null)
            {
                Console.WriteLine("The found person does not have a phone number");
            }
        }
    }
}
