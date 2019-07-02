﻿using BowlingGame;
using NUnit.Framework;
using System;

namespace BowlingGameTests
{
    public class BowlingGameTests
    {

        public Game game;

        [SetUp]
        public void SetupGame()
        {
            game = new Game();
        }

        public void RollMany(int numberOfRolls, int pinsFall)
        {

            for (int i = 0; i < numberOfRolls; i++)
            {
                game.Rolls(pinsFall);
            }

        }

        [Test]
        public void GutterGame()
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
        
        //[Test]
        //public void SpareRolls()
        //{
        //    RollMany(2, 5);
        //    RollMany(1, 3);

        //    Assert.AreEqual(16, game.Score());
        //}


    }
}
