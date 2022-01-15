using static Newtonsoft.Json.JsonConvert;

namespace UrbanPancake.Library
{
    public class Person
    {
        private string? firstName;
        private string? lastName;
        private string? phoneNumber;
        public string? FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string? LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string? PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public Person(string first, string last, string phoneNumber = "None")
        {
            FirstName = first;
            LastName = last;
            PhoneNumber = phoneNumber;
        }
    }
}

