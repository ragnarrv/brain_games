namespace BrainGames.games
{
    public static class ProgressionGame
    {
        private const int RoundsCount = 3;
        private const int MinLength = 5;
        private const int MaxLength = 10;
        private const int MinStart = 1;
        private const int MaxStart = 5;
        private const int MinRatio = 2;
        private const int MaxRatio = 5;

        public static void Run(string userName)
        {
            Console.WriteLine("What number is missing in the progression?");

            var random = new Random();

            for (int round = 0; round < RoundsCount; round++)
            {
                int length = random.Next(MinLength, MaxLength + 1);
                int start = random.Next(MinStart, MaxStart + 1);
                int ratio = random.Next(MinRatio, MaxRatio + 1);

                int[] progression = new int[length];
                progression[0] = start;
                for (int i = 1; i < length; i++)
                {
                    progression[i] = progression[i - 1] * ratio;
                }

                int hiddenIndex = random.Next(0, length);
                int correctAnswer = progression[hiddenIndex];

                string question = "";
                for (int i = 0; i < length; i++)
                {
                    if (i == hiddenIndex)
                    {
                        question += ".. ";
                    }
                    else
                    {
                        question += progression[i] + " ";
                    }
                }

                Console.WriteLine($"Question: {question.Trim()}");

                Console.Write("Your answer: ");
                string? userAnswer = Console.ReadLine();

                if (!int.TryParse(userAnswer, out int answer) || answer != correctAnswer)
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
