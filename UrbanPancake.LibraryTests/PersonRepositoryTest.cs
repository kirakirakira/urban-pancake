using System;
using Xunit;

namespace UrbanPancake.Library
{
    public class PersonRepositoryTest
    {
        [Fact]
        public void ShouldAddAPersonAndFindThem()
        {
            string dataFilePath = "/home/kira/git/urban-pancake/UrbanPancake/Data/PersonData.json";
            PersonRepository personRepository = new PersonRepository(dataFilePath);
            Person expected = new Person
            {
                FirstName = "Addie",
                LastName = "Tootles",
                PhoneNumber = "555-123-4567"
            };

            personRepository.Add(expected);

            Assert.Equal(expected, personRepository.FindPersonWith("Addie", "Tootles"));
        }

        [Fact]
        public void ShouldReturnNullIfPersonIsNotFound()
        {
            string dataFilePath = "/home/kira/git/urban-pancake/UrbanPancake/Data/PersonData.json";
            PersonRepository personRepository = new PersonRepository(dataFilePath);
            Person expected = new Person
            {
                FirstName = "Addie",
                LastName = "Tootles",
                PhoneNumber = "555-123-4567"
            };

            personRepository.Add(expected);

            Assert.Null(personRepository.FindPersonWith("Ryan", "Tootles"));
        }
    }
}
