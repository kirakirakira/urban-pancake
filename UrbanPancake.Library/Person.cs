﻿using static Newtonsoft.Json.JsonConvert;

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

        public int CreditCardNumber
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

        public Dictionary<string, Person> Relationships
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
            int creditCardNumber = 0,
            string? carModel = null,
            string? licensePlateNumber = null,
            string? occupation = null,
            Dictionary<string, Person>? relationships = null,
            string[]? hobbies = null)
        {
            if (relationships == null)
            {
                relationships = new Dictionary<string, Person>();
            }
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

