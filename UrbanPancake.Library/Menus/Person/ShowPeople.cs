namespace UrbanPancake.Library
{
    public class ShowPeople : IMenuFunction
    {
        public string Choice { get; set; } = "View all people";
        public int ExecuteChoice()
        {
            PersonRepository personRepository = new PersonRepository();

            IEnumerable<Person> people = personRepository.GetAllItems();
            foreach (Person person in people)
            {
                Console.WriteLine(person + "\n");
            }

            return (int)MenuFunctions.ContinueCurrentMenu;
        }
    }
}
