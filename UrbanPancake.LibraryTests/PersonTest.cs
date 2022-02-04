using System;
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

        // [Fact]
        // public void PrintsNameWhenConsoleWriteLined()
        // {
        //     Person me = new Person("Kira", "Bubbles", "555-123-4567");
        //     Assert.Equal("Kira Bubbles", output.WriteLine(me));
        // }
    }
}
