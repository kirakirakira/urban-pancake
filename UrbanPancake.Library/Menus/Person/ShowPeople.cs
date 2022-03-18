namespace UrbanPancake.Library
{
    public class ShowPeople : IMenuFunction
    {
        public string Choice { get; set; } = "View all people";
        public int ExecuteChoice()
        {
            string dataFilePath = "UrbanPancake/Data/PersonData.json";
            PersonRepository personRepository = new PersonRepository(dataFilePath);

            IEnumerable<Person> people = personRepository.GetAllItems();
            foreach (Person person in people)
            {
                Console.WriteLine(person + "\n");
            }

            return (int)MenuFunctions.ContinueCurrentMenu;
        }
    }
}
