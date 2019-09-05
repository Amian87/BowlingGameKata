using System;

namespace BowlingGame
{
    public class Game
    {
        private int score = 0;
        private int currentRoll = 0;
        private int[] rolls = new int[21];

        public void Roll(int pinsFall)
        {
            rolls[currentRoll++] += pinsFall;
            score += pinsFall;
        }

        public int Score()
        {
            int score = 0;
            int frameIndex = 0;

            for(int frame = 0; frame < 10; frame++)
            {
                if (isStrike(frameIndex))
                {
                    score += 10 + rolls[frameIndex + 1] + rolls[frameIndex + 2];
                    frameIndex += 1;
                }

                else if (isSpare(frameIndex))
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

        private bool isSpare(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1] == 10;
        }

        private bool isStrike(int frameIndex)
        {
            return rolls[frameIndex] == 10;
        }
    }
}
