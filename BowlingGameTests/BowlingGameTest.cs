using BowlingGame;
using NUnit.Framework;
using System;

namespace BowlingGameTests
{
    public class BowlingGameTest
    {
        private Game game;

        [SetUp]
        public void SetupGame()
        {
            game = new Game();
        }

        public void RollManyTimes(int numberOfRolls, int pinsFall)
        {
            for(int i = 0; i < numberOfRolls; i++)
            {
                game.Roll(pinsFall);
            }
        }

        [Test]
        public void GutterGame()
        {
            RollManyTimes(20, 0);
            Assert.AreEqual(0, game.Score());
        }

        [Test]
        public void RollAllOnes()
        {
            RollManyTimes(20, 1);
            Assert.AreEqual(20, game.Score());
        }

        [Test]
        public void RollOneSpare()
        {
            RollManyTimes(2, 5);
            RollManyTimes(1, 3);
            RollManyTimes(17, 0);
            Assert.AreEqual(16, game.Score());
        }

        [Test]
        public void RollOneStrike()
        {
            RollManyTimes(1, 10);
            RollManyTimes(1, 3);
            RollManyTimes(1, 4);
            Assert.AreEqual(24, game.Score());
        }

        [Test]
        public void PerfectGame()
        {
            RollManyTimes(20, 10);
            Assert.AreEqual(300, game.Score());
        }

        [Test]
        public void RandomGame()
        {
            RollManyTimes(1, 10);
            RollManyTimes(2, 4);
            RollManyTimes(1, 0);
            RollManyTimes(2, 5);
            RollManyTimes(15, 0);
            Assert.AreEqual(89, game.Score());
        }

    }
}
