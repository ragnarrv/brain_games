namespace BrainGames.games
{
    public static class LCMGame
    {
        private const int MinNumber = 1;
        private const int MaxNumber = 100;

        public static void StartGame(string userName)
        {
            string description = "Find the smallest common multiple of given numbers.";

            var random = new Random();

            (string question, string correctAnswer) GenerateRound()
            {
                int a = random.Next(MinNumber, MaxNumber + 1);
                int b = random.Next(MinNumber, MaxNumber + 1);
                int c = random.Next(MinNumber, MaxNumber + 1);

                string question = $"{a} {b} {c}";

                int correct = Lcm(a, b, c);
                return (question, correct.ToString());
            }

            Engine.RunGame(description, GenerateRound, userName);
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

