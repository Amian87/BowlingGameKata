﻿using System;

namespace BowlingGame
{
    public class Game
    {
        private int currentScore = 0;
        private int[] rolls = new int[21];
 
        public void Roll(int pinsFall)
        {
            rolls[currentScore++] += pinsFall;
        }

        public int Score()
        {
            var score = 0;
            var frameIndex = 0;

            for (var frame = 0; frame < 10; frame++)
            {
                if (IsStrike(frameIndex))
                {
                    score += 10 + rolls[frameIndex + 1] + rolls[frameIndex + 2];
                    frameIndex += 1;
                }
                else if (IsSpare(frameIndex))
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

        private bool IsSpare(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1] == 10;
        }

        private bool IsStrike(int frameIndex)
        {
            return rolls[frameIndex] == 10;
        }
    }
}
