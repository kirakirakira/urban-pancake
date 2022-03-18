using System.Text;
using System.Text.Json;

namespace UrbanPancake.Library
{
    public class PersonRepository : IRepository<Person>
    {
        private readonly List<Person> _allPersons = new List<Person>();

        public void Add(Person item)
        {
            _allPersons.Add(item);
        }

        public IEnumerable<Person> GetAllItems()
        {
            return _allPersons;
        }

        public Person? FindPersonWith(string first, string last)
        {
            Person? foundPerson;
            try
            {
                foundPerson = _allPersons.Find(person => person.FirstName == first && person.LastName == last);
                return foundPerson;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public PersonRepository(string dataFilePath)
        {
            var persons = JsonSerializer.Deserialize<List<Person>>(File.ReadAllText(@dataFilePath));

            for (int i = 0; i < persons?.Count; i++)
            {
                _allPersons.Add(persons[i]);
            }
        }
    }
}
