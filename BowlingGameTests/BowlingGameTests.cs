using BowlingGame;
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

        [Test]
        public void RollOneSpare()
        {
            RollMany(2, 5);
            RollMany(1, 3);
            RollMany(17, 0);
            Assert.AreEqual(16, game.Score());

        }

        [Test]
        public void RollOneStrike()
        {
            RollMany(1, 10);
            RollMany(1, 3);
            RollMany(1, 4);
            RollMany(16, 0);
            Assert.AreEqual(24, game.Score());
        }

        [Test]
        public void PerfectGame()
        {
            RollMany(12, 10);
            Assert.AreEqual(300, game.Score());
        }
    }
}
