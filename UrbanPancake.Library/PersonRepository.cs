using System;

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

        public PersonRepository()
        {
        }
    }
}
