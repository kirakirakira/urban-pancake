using static Newtonsoft.Json.JsonConvert;

namespace UrbanPancake.Library
{
    public class Person
    {
        public string? FirstName
        {
            get; set;
        }

        public string? LastName
        {
            get; set;
        }

        public string? PhoneNumber
        {
            get; set;
        }

        public Person(string first, string last, string phoneNumber = "None")
        {
            FirstName = first;
            LastName = last;
            PhoneNumber = phoneNumber;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}

