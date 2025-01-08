namespace BrainGames.src
{
    public static class Cli
    {
        public static string GreetUser()
        {
            Console.WriteLine("Welcome to the Brain Games!");
            Console.Write("May I have your name? ");
            string userName = Console.ReadLine() ?? "Player";
            Console.WriteLine($"Hello, {userName}!");
            return userName;
        }
    }
}
