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
            Person you = new Person("Kira", "Bubbles", "513-234-2421");
            Console.WriteLine(you);

            var persons = JsonSerializer.Deserialize<Person>(File.ReadAllText(@"UrbanPancake/PersonData.json"));
        }
    }
}
