using BrainGames.src;           
using BrainGames.games;

namespace BrainGames
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // Приветствие
            string userName = Cli.GreetUser();

            // Меню выбора игры
            Console.WriteLine("Выберите игру:");
            Console.WriteLine("1. Н.О.К. ");
            Console.WriteLine("2. Геометрическая прогрессия");
            Console.Write("Ваш выбор: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    LCMGame.StartGame(userName);
                    break;
                case "2":
                    ProgressionGame.StartGame(userName);
                    break;
                
            }
        }
    }
}


