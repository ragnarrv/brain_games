namespace BrainGames.games
{
    public static class LCMGame
    {
        private const int RoundsCount = 3;
        private const int MinNumber = 1;
        private const int MaxNumber = 100;

        public static void Run(string userName)
        {
            Console.WriteLine("Find the smallest common multiple of given numbers.");

            var random = new Random();

            for (int round = 0; round < RoundsCount; round++)
            {
                int a = random.Next(MinNumber, MaxNumber + 1);
                int b = random.Next(MinNumber, MaxNumber + 1);
                int c = random.Next(MinNumber, MaxNumber + 1);

                Console.WriteLine($"Question: {a} {b} {c}");
                Console.Write("Your answer: ");
                string? userAnswer = Console.ReadLine();

                int correctAnswer = Lcm(a, b, c);

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

        private static int Lcm(int a, int b, int c)
        {
            return Lcm(Lcm(a, b), c);
        }

        private static int Lcm(int x, int y)
        {
            return x * y / Gcd(x, y);
        }

        private static int Gcd(int x, int y)
        {
            while (y != 0)
            {
                int temp = y;
                y = x % y;
                x = temp;
            }
            return x;
        }
    }
}
