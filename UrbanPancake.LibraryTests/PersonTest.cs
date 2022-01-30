using System;
using Xunit;
using Xunit.Abstractions;

namespace UrbanPancake.Library
{
    public class PersonTest
    {
        private readonly ITestOutputHelper output;

        public ITestOutputHelper MyTestClass(ITestOutputHelper output)
        {
            this.output;
        }

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
        public void PrintsNameWhenConsoleWriteLined()
        {
            Person me = new Person("Kira", "Bubbles", "555-123-4567");
            Assert.Equal("Kira Bubbles", output.WriteLine(me));
        }
    }
}
