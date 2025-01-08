
namespace BrainGames
{
    public static class Engine
    {
        private const int RoundsCount = 3;

        public delegate (string question, string correctAnswer) RoundData();

        public static void RunGame(string description, RoundData generateRound, string userName)
        {
            Console.WriteLine(description);

            for (int i = 0; i < RoundsCount; i++)
            {
                var (question, correctAnswer) = generateRound();

                Console.WriteLine($"Question: {question}");
                Console.Write("Your answer: ");
                string? userAnswer = Console.ReadLine();

                if (userAnswer != correctAnswer)
                {
                    Console.WriteLine($"'{userAnswer}' is wrong answer ;(. Correct answer was '{correctAnswer}'.");
                    Console.WriteLine($"Let's try again, {userName}!");
                    return;
                }

                Console.WriteLine("Correct!");
            }

            Console.WriteLine($"Congratulations, {userName}!");
        }
    }
}
