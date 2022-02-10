using System;
using System.Collections.Generic;
using Xunit;

namespace UrbanPancake.Library
{
    public class PersonTest
    {
        [Fact]
        public void HasAName()
        {
            Person me = new Person("Kira", "Bubbles");
            Assert.Equal("Kira", me.FirstName);
            Assert.Equal("Bubbles", me.LastName);
        }

        [Fact]
        public void HasAPhoneNumber()
        {
            Person me = new Person("Kira", "Bubbles", "555-123-4567");
            Assert.Equal("555-123-4567", me.PhoneNumber);
        }

        [Fact]
        public void HasNoPhoneNumber()
        {
            Person me = new Person("Kira", "Bubbles");
            Assert.Null(me.PhoneNumber);
        }

        [Fact]
        public void HasADriversLicense()
        {
            Person me = new Person("Kira", "Bubbles", "555-123-4567", "123456");
            Assert.Equal("123456", me.DriversLicense);
        }

        [Fact]
        public void HasADriversLicenseAndNoPhoneNumber()
        {
            Person me = new Person("Kira", "Bubbles", driversLicense: "123456");
            Assert.Equal("123456", me.DriversLicense);
            Assert.Null(me.PhoneNumber);
        }

        [Fact]
        public void HasAPhoneNumberAndNoDriversLicense()
        {
            Person me = new Person("Kira", "Bubbles", phoneNumber: "555-123-4567");
            Assert.Equal("555-123-4567", me.PhoneNumber);
            Assert.Null(me.DriversLicense);
        }

        [Fact]
        public void HasBelongings()
        {
            string[] stuff = { "wallet", "keys", "coupons", "Costco receipt" };
            Person me = new Person("Kira", "Bubbles", belongings: stuff);
            Assert.Equal(stuff, me.Belongings);
        }

        [Fact]
        public void HasCreditCardNumber()
        {
            Person me = new Person("Kira", "Bubbles", creditCardNumber: 1234567890);
            Assert.Equal(1234567890, me.CreditCardNumber);
        }

        [Fact]
        public void HasACarModel()
        {
            Person me = new Person("Kira", "Bubbles", carModel: "Toyota Prius");
            Assert.Equal("Toyota Prius", me.CarModel);
        }

        [Fact]
        public void HasALicensePlateNumber()
        {
            Person me = new Person("Kira", "Bubbles", licensePlateNumber: "ACME123");
            Assert.Equal("ACME123", me.LicensePlateNumber);
        }

        [Fact]
        public void HasAJob()
        {
            Person me = new Person("Kira", "Bubbles", occupation: "Taco Food Truck Owner");
            Assert.Equal("Taco Food Truck Owner", me.Occupation);
        }

        [Fact]
        public void HasRelationshipsWithOtherPeople()
        {
            Dictionary<string, Person> relationships = new Dictionary<string, Person>();
            Person me = new Person("Kira", "Bubbles", relationships: relationships);
            Person husband = new Person("Papa", "Pig");
            Person child = new Person("Peppa", "Pig");
            Assert.Equal(relationships, me.Relationships);
        }

        [Fact]
        public void HasHobbies()
        {
            string[] stuff = { "soccer", "reading", "playing Mario Kart" };
            Person me = new Person("Kira", "Bubbles", hobbies: stuff);
            Assert.Equal(stuff, me.Hobbies);
        }

        [Fact]
        public void PrintsNameWhenToStringCalled()
        {
            Person me = new Person("Kira", "Bubbles", "555-123-4567");
            Assert.Equal("Kira Bubbles", me.ToString());
        }
    }
}
