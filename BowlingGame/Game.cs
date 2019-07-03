﻿using System;
using System.Collections.Generic;

namespace BowlingGame
{
    public class Game
    {
        private List<int> rolls = new List<int>(21);
        private int currentRoll = 0;


        public void Rolls(int pinsFall)
        {
            rolls.Add(pinsFall);
            
        }

        public int Score()
        {
            int score = 0;
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if(isSpare(frameIndex))
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

    }
}
