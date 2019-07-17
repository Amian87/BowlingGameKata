using System;

namespace BowlingGame
{
    public class Game
    {

        private int currentRoll = 0;
        private int[] roll = new int[21];

        public void Roll(int pinsFall)
        {
            roll[currentRoll++] = pinsFall;

        }

        public int Score()
        {
            int score = 0;
            int frameIndex = 0;

            for(int frame = 0; frame < 10; frame++)
            {
                if (IsStrike(frameIndex))
                {
                    score += 10 + roll[frameIndex + 1] + roll[frameIndex + 2];
                    frameIndex++;
                }

                else if (IsSpare(frameIndex))
                {
                    score += 10 + roll[frameIndex + 2];
                    frameIndex += 2;
                }
                else
                {
                    score += roll[frameIndex] + roll[frameIndex + 1];
                    frameIndex += 2;
                }

            }

            return score;
        }

        private bool IsStrike(int frameIndex)
        {
            return roll[frameIndex] == 10;
        }

        private bool IsSpare(int frameIndex)
        {
            return roll[frameIndex] + roll[frameIndex + 1] == 10;
        }
    }
}
