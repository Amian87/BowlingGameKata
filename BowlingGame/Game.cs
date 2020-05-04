using System;
using System.Runtime.CompilerServices;

namespace BowlingGame
{
    public class Game
    {
        private readonly int[] _roll = new int[21];
        private int _currentScore = 0;

        public void Roll(int numberOfPinsFall)
        {
            _roll[_currentScore++] += numberOfPinsFall;
        }

        public int Score()
        {
            int score = 0;
            int frameIndex = 0;

            for (int frame = 0; frame < 10; frame++)
            {
                if (_roll[frameIndex] == 10)
                {
                    score += 10 + _roll[frameIndex + 1] + _roll[frameIndex + 2];
                    frameIndex += 1;
                }
                else if (_roll[frameIndex] + _roll[frameIndex + 1] == 10)
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

    }
}
