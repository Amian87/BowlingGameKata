using System;

namespace BowlingGame
{
    public class Game
    {
        private readonly int[] _rolls = new int[21];
        private int currentScore = 0;

        public void Roll(int pinsFall)
        {
            _rolls[currentScore++] += pinsFall;
        }

        public int Score()
        {
            int score = 0;
            int frameIndex = 0;

            for (int frame = 0; frame < 10; frame++)
            {
                if (_rolls[frameIndex] == 10)
                {
                    score += 10 + _rolls[frameIndex + 1] + _rolls[frameIndex + 2];
                    frameIndex += 1;
                }
                else if (_rolls[frameIndex] + _rolls[frameIndex + 1] == 10)
                {
                    score += 10 + _rolls[frameIndex + 2];
                    frameIndex += 2;
                }
                else
                {
                    score += _rolls[frameIndex] + _rolls[frameIndex + 1];
                    frameIndex += 2;
                }
            }

            return score;
        }
    }
}
