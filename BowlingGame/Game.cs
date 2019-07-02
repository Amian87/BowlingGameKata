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
            if (IsStrike(pinsFall))
            {
                tally.Add(0);
            }
        }

        public int Score()
        {
            int totalScore = 0;
            int scoreForCurrentFrame = 0;
            int checkStrike = 0;

            for (int i = 0; i < NumberOfRollsToCount(); i=i+2)
            {
                scoreForCurrentFrame = tally[i] + tally[i + 1];
                totalScore += scoreForCurrentFrame;
                checkStrike = tally[i];

                if (checkStrike == 10)
                {
                    totalScore += tally[i + 2] + tally[i + 3];
                   
                }
                else if (FrameIsSpare(scoreForCurrentFrame))
                {
                    totalScore += tally[i + 2];
                }
            }

            return totalScore;
        }

        private int NumberOfRollsToCount()
        {
            if(tally.Count < 20)
            {
                return tally.Count;
            } else
            {
                return 20;
            }
        }
        

        private static bool FrameIsSpare(int scoreForCurrentFrame)
        {
            return scoreForCurrentFrame == 10;
        }

        private bool IsStrike(int pinsFall)
        {
            if (tally.Count % 2 == 1)
            {
                return pinsFall == 10;
            }
            else
                return false;
        }

    }
}
