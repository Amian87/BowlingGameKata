using System;

namespace BowlingGame
{
    public class Game
    {
        private int currentRoll = 0;
        private int[] roll = new int[21];
            
        public void Roll(int pinsFall)
        {
            roll[currentRoll++] += pinsFall;
     
        }

        public int Score()
        {
            int score = 0;
            int i = 0;

            for(int frame = 0; frame < 10; frame++)
            {
                if(roll[i] + roll[i + 1] == 10)
                {
                    score += 10 + roll[i + 2];
                    i += 2;
                }
                else
                {
                    score += roll[i] + roll[i + 1];
                    i += 2;
                }

            }

            return score;
        }

    }
}
