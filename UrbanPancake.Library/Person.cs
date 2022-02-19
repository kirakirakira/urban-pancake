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

        public string[]? Belongings
        {
            get; set;
        }

        public string? CreditCardNumber
        {
            get; set;
        }

        public string? CarModel
        {
            get; set;
        }

        public string? LicensePlateNumber
        {
            get; set;
        }

        public string? Occupation
        {
            get; set;
        }

        public Dictionary<string, string>? Relationships
        {
            get; set;
        }

        public string[]? Hobbies
        {
            get; set;
        }

        public Person() { }

        public Person(
            string first,
            string last,
            string? phoneNumber = null,
            string? driversLicense = null,
            string[]? belongings = null,
            string? creditCardNumber = null,
            string? carModel = null,
            string? licensePlateNumber = null,
            string? occupation = null,
            Dictionary<string, string>? relationships = null,
            string[]? hobbies = null)
        {
            FirstName = first;
            LastName = last;
            PhoneNumber = phoneNumber;
            DriversLicense = driversLicense;
            Belongings = belongings;
            CreditCardNumber = creditCardNumber;
            CarModel = carModel;
            LicensePlateNumber = licensePlateNumber;
            Occupation = occupation;
            Relationships = relationships;
            Hobbies = hobbies;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}

