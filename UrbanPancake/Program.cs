using UrbanPancake.Library;

namespace UrbanPancake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("**********************************");
            Console.WriteLine("Welcome to Mystery Hour\n");
            Console.WriteLine("\n");

            string mystery = System.IO.File.ReadAllText("./UrbanPancake/Mystery.txt");
            Console.WriteLine(mystery);

            Console.WriteLine("\n");

            string mission = System.IO.File.ReadAllText("./UrbanPancake/Mission.txt");
            Console.WriteLine(mission);

            MainMenu menu = new MainMenu();

            var keepGoing = (int)MenuFunction.ContinueCurrentMenu;
            while (keepGoing == (int)MenuFunction.ContinueCurrentMenu)
            {
                keepGoing = (int)menu.ExecuteChoice();
            }
        }
    }
}
