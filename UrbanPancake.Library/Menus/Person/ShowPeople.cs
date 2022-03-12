namespace UrbanPancake.Library
{
    public class ShowPeople : IMenuItem
    {
        public string Choice { get; set; } = "View all people";
        public int ExecuteChoice()
        {
            PersonRepository personRepository = new PersonRepository();
            Console.WriteLine(personRepository);

            return (int)MenuFunctions.ContinueCurrentMenu;
        }
    }
}
