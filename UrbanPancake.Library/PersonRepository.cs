using System.Text;

namespace UrbanPancake.Library
{
    public class PersonRepository
    {
        private readonly List<Person> _allPersons = new List<Person>();

        public void Add(Person person)
        {
            _allPersons.Add(person);
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

        public PersonRepository()
        {
        }
    }
}
