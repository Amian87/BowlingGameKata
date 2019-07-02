using System;
using System.Collections.Generic;

namespace BowlingGame
{
    public class Game
    {
        private List<int> tally = new List<int>();

        public void Rolls(int pinsFall)
        {
            tally.Add(pinsFall);
        }

        public int Score()
        {
            int totalScore = 0;
            int scoreForCurrentFrame = 0;

            for (int i = 0; i < tally.Count; i=i+2)
            {
                scoreForCurrentFrame = tally[i] + tally[i + 1];
                totalScore += scoreForCurrentFrame;

                if(scoreForCurrentFrame == 10)
                {
                    totalScore += tally[i + 2];

                }
                
            }

            return totalScore;
        }

    }
}
