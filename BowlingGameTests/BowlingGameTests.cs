﻿using BowlingGame;
using NUnit.Framework;
using System;

namespace BowlingGameTests
{
    public class BowlingGameTests
    {
        private Game game;

        [SetUp]
        public void SetupGame()
        {
            game = new Game();       
        }

        public void RollMany(int numberOfRolls, int pinsFall)
        {
           for(int i = 0; i < 20; i++)
            {
                game.Roll(pinsFall);
            }
        }

        [Test]
        public void GutterRolls()
        {
            RollMany(20, 0);
            Assert.AreEqual(0, game.Score());
        }


        [Test]
        public void RollAllOnes()
        {
            RollMany(20, 1);
            Assert.AreEqual(20, game.Score());
        }

        [Test]
        public void RollOneSpare()
        {
            game.Roll(5);
            game.Roll(5);
            game.Roll(3);
            RollMany(17, 0);
            Assert.AreEqual(16, game.Score());
        }

        
        


    }
}
