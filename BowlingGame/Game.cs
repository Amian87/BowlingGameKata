using System;

namespace BowlingGame
{
    public class Game
    {
        private int score = 0;

        public void Rolls(int pinsHit)
        {
            score += pinsHit;

        }

        public int Score()
        {
            return score;
        }
    }
}
