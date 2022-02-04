using System;
using Xunit;

namespace UrbanPancake.Library
{
    public class PersonRepositoryTest
    {
        [Fact]
        public void HasAPerson()
        {
            // var personRepository = new PersonRepositoryTest();
            Person expected = new Person
            {
                FirstName = "Kira",
                LastName = "Bubbles",
                PhoneNumber = "555-123-4567"
            };
        }
    }
}
