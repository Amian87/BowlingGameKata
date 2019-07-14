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
            for(int i = 0; i < numberOfRolls; i++)
            {
                game.Roll(pinsFall);
            }
        }

        [Test]
        public void GutterRoll()
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

        [Test]
        public void RollOneStrike()
        {
            game.Roll(10);
            game.Roll(3);
            game.Roll(4);
            RollMany(16, 0);
            Assert.AreEqual(24, game.Score());
        }
        
        [Test]
        public void PerfectGame()
        {
            RollMany(12, 10);
            Assert.AreEqual(300, game.Score());
        }

        [Test]
        public void SpareWithATen()
        {
            RollMany(1, 0);
            RollMany(1, 10);
            RollMany(1, 5);
            RollMany(1, 1);
            Assert.AreEqual(21, game.Score());

        }
        
        [Test]
        public void FinalFrameAsSpare()
        {
            RollMany(18, 0);
            RollMany(2, 5);
            RollMany(1, 1);

            Assert.AreEqual(11, game.Score());
        }




    }
}
