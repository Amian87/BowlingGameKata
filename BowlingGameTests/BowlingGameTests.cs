using BowlingGame;
using NUnit.Framework;
using System;

namespace BowlingGameTests
{
    public class BowlingGameTests
    {
        private Game game = new Game();

        [SetUp]
        public void SetUpGame()
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
    }
}
