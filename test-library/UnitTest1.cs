using System;
using Xunit;

namespace library
{
    public class Test_Person
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
    }
}
