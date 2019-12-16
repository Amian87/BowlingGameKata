using System;

namespace BowlingGame
{
    public class Game
    {
        private int _currentScore = 0;
        private readonly int[] _roll = new int[21];

        public void Roll(int pinsFall)
        {
            _roll[_currentScore++] += pinsFall;
        }

        public int Score()
        {
            var score = 0;
            var frameIndex = 0;

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
