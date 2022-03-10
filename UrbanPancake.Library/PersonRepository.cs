using System.Text;
using System.Text.Json;

namespace UrbanPancake.Library
{
    public class PersonRepository // : IEnumerable<int>
    {
        private readonly List<Person> _allPersons = new List<Person>();

        public void Add(Person person)
        {
            _allPersons.Add(person);
        }

        public int Count()
        {
            return _allPersons.Count();
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (_allPersons.Count != 0)
            {
                sb.Append("The people in the repository are: \n");
                foreach (Person? person in _allPersons)
                {
                    sb.Append(person.ToString() + "\n");
                }
            }
            else
            {
                sb.Append("There are no people in the repository.");
            }

            return sb.ToString();
        }

        // public IEnumerator<Person> GetEnumerator()
        // {
        //     return _allPersons.GetEnumerator();
        // }

        // IEnumerator IEnumerable.GetEnumerator()
        // {
        //     return this.GetEnumerator();
        // }

        // public Person this[int index]
        // {
        //     get { return _allPersons[index]; }
        //     set { _allPersons.Insert(index, value); }
        // }

        public PersonRepository()
        {
            var persons = JsonSerializer.Deserialize<List<Person>>(File.ReadAllText(@"UrbanPancake/Data/PersonData.json"));

            for (int i = 0; i < persons?.Count; i++)
            {
                _allPersons.Add(persons[i]);
            }
        }
    }
}
