using System;

namespace BowlingGame
{
    public class Game
    {
        private readonly int[] _roll = new int[21];
        private int currentScore = 0;

        public void Roll(int numberOfPinsFall)
        {
            _roll[currentScore++] += numberOfPinsFall;
        }

        public int Score()
        {
            int score = 0;
            int frameIndex = 0;

            for (int frame = 0; frame < 10; frame++)
            {
                if (IsStrike(frameIndex))
                {
                    score += 10 + _roll[frameIndex + 1] + _roll[frameIndex + 2];
                    frameIndex += 1;
                }
                else if (IsSpare(frameIndex))
                {
                    score += 10 + _roll[frameIndex + 2];
                    frameIndex += 2;
                }
                else
                {
                    score += _roll[frameIndex] + _roll[frameIndex + 1];
                    frameIndex += 2;
                }
            }

            return score;
        }

        private bool IsSpare(int frameIndex)
        {
            return _roll[frameIndex] + _roll[frameIndex + 1] == 10;
        }

        private bool IsStrike(int frameIndex)
        {
            return _roll[frameIndex] == 10;
        }
    }
}
