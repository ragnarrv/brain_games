namespace BrainGames.games
{
    public static class ProgressionGame
    {
        private const int MinLength = 5;
        private const int MaxLength = 10;
        private const int MinStart = 1;
        private const int MaxStart = 5;
        private const int MinRatio = 2;
        private const int MaxRatio = 5;

        public static void StartGame(string userName)
        {
            string description = "What number is missing in the progression?";

            var random = new Random();

            (string question, string correctAnswer) GenerateRound()
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

                string questionStr = "";
                for (int i = 0; i < length; i++)
                {
                    if (i == hiddenIndex)
                    {
                        questionStr += ".. ";
                    }
                    else
                    {
                        questionStr += progression[i] + " ";
                    }
                }

                questionStr = questionStr.Trim();

                return (questionStr, correctAnswer.ToString());
            }

            Engine.RunGame(description, GenerateRound, userName);
        }
    }
}


