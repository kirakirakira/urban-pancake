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

        public void DisplayDetails()
        {
            string stuff = "";
            if (Belongings?.Count() > 0)
            {
                stuff = string.Join(", ", Belongings);
            }


            string activities = "";
            if (Hobbies?.Count() > 0)
            {
                activities = string.Join(", ", Hobbies);
            }

            string peeps = "";
            if (Relationships?.Count() > 0)
            {
                peeps = string.Join(", ", Relationships);
            }

            string details = this.ToString() + "\n" +
                            "Driver license number: " + DriversLicense + "\n" +
                            "Belongings: " + stuff + "\n" +
                            "Credit Card Number: " + CreditCardNumber + "\n" +
                            "Car Model: " + CarModel + "\n" +
                            "License Plate Number: " + LicensePlateNumber + "\n" +
                            "Occupation: " + Occupation + "\n" +
                            "Relationships: " + peeps + "\n" +
                            "Hobbies: " + activities + "\n";
            Console.WriteLine(details);
        }
    }
}

