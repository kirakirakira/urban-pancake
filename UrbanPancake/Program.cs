using System;
using UrbanPancake.Library;

namespace UrbanPancake
{
    class Program
    {
        static void Main(string[] args)
        {
            Person you = new Person("Kira", "Bubbles", "513-234-2421");
            Console.WriteLine(you);
        }
    }
}
