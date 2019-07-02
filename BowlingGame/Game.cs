using System;
using System.Collections.Generic;

namespace BowlingGame
{
    public class Game
    {
        
        private List<int> score = new List<int>();



        public void Rolls(int pinsFall)
        {
            score.Add(pinsFall);
        }

        public int Score()
        {
            int totalScore = 0;

            for (int i = 0; i < score.Count; i++ )
            {
                totalScore += score[i]; 
            }

            return totalScore;
        }




    }
}
