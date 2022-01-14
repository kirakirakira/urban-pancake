using static Newtonsoft.Json.JsonConvert;

namespace library
{
    public class Person
    {
        private string firstName;
        private string lastName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public Person(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }
    }
}

