using UrbanPancake.Library;

namespace UrbanPancake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("**********************************");
            Console.WriteLine("Welcome to Mystery Hour\n");

            string mystery = System.IO.File.ReadAllText("./UrbanPancake/Mystery.txt");
            Console.WriteLine(mystery);

            string mission = System.IO.File.ReadAllText("./UrbanPancake/Mission.txt");
            Console.WriteLine(mission);

            Console.WriteLine("Press any key to accept the undertaking of solving this mystery. Grab a pen and paper to take notes.");
            Console.ReadKey();
            Console.Clear();

            MainMenu menu = new MainMenu();

            var keepGoing = (int)MenuFunctions.ContinueCurrentMenu;
            while (keepGoing == (int)MenuFunctions.ContinueCurrentMenu)
            {
                keepGoing = (int)menu.ExecuteChoice();
            }
        }
    }
}
