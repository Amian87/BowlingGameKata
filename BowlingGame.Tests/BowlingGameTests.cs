using System;
using NUnit.Framework;

namespace BowlingGame.Tests
{
    public class BowlingGameTests
    {
        private Game game;

        [SetUp]
        public void SetUpGame()
        {
            game = new Game();
        }

        public void RollManyTimes(int numberOfRolls, int numberOfPinsFall)
        {
            for (int i = 0; i < numberOfRolls; i++)
            {
                game.Roll(numberOfPinsFall);
            }
        }

        [Test]
        public void TestGutterGame()
        {
            RollManyTimes(20, 0);
            Assert.AreEqual(0, game.Score());
        }

        [Test]
        public void TestRollAllOnes()
        {
            RollManyTimes(20, 1);
            Assert.AreEqual(20, game.Score());
        }

        [Test]
        public void TestRollOneSpare()
        {
            RollManyTimes(2, 5);
            RollManyTimes(1, 3);
            Assert.AreEqual(16, game.Score());
        }

        [Test]
        public void TestRollOneStrike()
        {
            RollManyTimes(1, 10);
            RollManyTimes(1, 3);
            RollManyTimes(1, 4);
            Assert.AreEqual(24, game.Score());
        }

        [Test]
        public void TestPerfectGame()
        {
            RollManyTimes(20, 10);
            Assert.AreEqual(300, game.Score());
        }

      

    }
}
