using BrainGames.src; 
using BrainGames.games;


namespace BrainGames
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Приветствие
            string userName = Cli.GreetUser();

            // Выбор игры
            Console.WriteLine("Выберите игру:");
            Console.WriteLine("1. Н.О.К.");
            Console.WriteLine("2. Геометрическая прогрессия");
            Console.Write("Ваш выбор: ");
            string choice = Console.ReadLine() ?? "1";

            switch (choice)
            {
                case "1":
                    LCMGame.Run(userName);
                    break;
                case "2":
                    ProgressionGame.Run(userName);
                    break;
                
            }
        }
    }
}
