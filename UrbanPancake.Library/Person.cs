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

        public string? DriversLicense
        {
            get; set;
        }

        public Person(string first, string last, string? phoneNumber = null, string? driversLicense = null)
        {
            FirstName = first;
            LastName = last;
            PhoneNumber = phoneNumber;
            DriversLicense = driversLicense;
        }
        
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}

