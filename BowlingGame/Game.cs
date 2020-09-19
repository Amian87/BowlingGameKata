using System;
using System.Runtime.InteropServices.ComTypes;

namespace BowlingGame
{
    public class Game
    {
        private int[] rolls = new int[21];
        private int currentScore = 0;

        public void Roll(int numberOfPinsFall)
        {
            rolls[currentScore++] += numberOfPinsFall;
        }

        public int Score()
        {
            int score = 0;
            int frameIndex = 0;

            for (int frame = 0; frame < 10; frame++)
            {
                if (rolls[frameIndex] == 10)
                {
                    score += 10 + rolls[frameIndex + 1] + rolls[frameIndex + 2];
                    frameIndex += 1;
                }
                else if (rolls[frameIndex] + rolls[frameIndex + 1] == 10)
                {
                    score += 10 + rolls[frameIndex + 2];
                    frameIndex += 2;
                }
                else
                {
                    score += rolls[frameIndex] + rolls[frameIndex + 1];
                    frameIndex += 2;
                }
            }

            return score;
        }
    }
}
