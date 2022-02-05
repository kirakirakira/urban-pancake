using System;
using Xunit;

namespace UrbanPancake.Library
{
    public class PersonRepositoryTest
    {
        [Fact]
        public void ShouldAddAPersonAndFindThem()
        {
            PersonRepository personRepository = new PersonRepository();
            Person expected = new Person
            {
                FirstName = "Kira",
                LastName = "Bubbles",
                PhoneNumber = "555-123-4567"
            };

            personRepository.Add(expected);

            Assert.Equal(expected, personRepository.FindPersonWith("Kira", "Bubbles"));
        }

        [Fact]
        public void ShouldReturnNullIfPersonIsNotFound()
        {
            PersonRepository personRepository = new PersonRepository();
            Person expected = new Person
            {
                FirstName = "Kira",
                LastName = "Bubbles",
                PhoneNumber = "555-123-4567"
            };

            personRepository.Add(expected);

            Assert.Null(personRepository.FindPersonWith("Ryan", "Bubbles"));
        }
    }
}
