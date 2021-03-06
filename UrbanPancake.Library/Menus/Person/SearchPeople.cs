namespace UrbanPancake.Library
{
    public class SearchPeople : IMenuFunction
    {
        public string Choice { get; set; } = "Search for a specific person";
        public int ExecuteChoice()
        {
            Console.WriteLine("Who would you like information about?");
            Console.WriteLine("What is their first name?");
            string? firstName = Console.ReadLine();
            Console.WriteLine("What is their last name?");
            string? lastName = Console.ReadLine();

            string dataFilePath = "UrbanPancake/Data/PersonData.json";
            PersonRepository personRepository = new PersonRepository(dataFilePath);
            if (firstName != null && lastName != null)
            {
                Person? found = personRepository.FindPersonWith(firstName, lastName);
                if (found != null)
                {
                    Console.WriteLine("\n" + found.GetDetails());
                }
                else
                {
                    Console.WriteLine("Person doesn't exist.");
                }
            }

            return (int)MenuFunctions.ContinueCurrentMenu;
        }
    }
}
