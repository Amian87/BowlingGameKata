using BowlingGame;
using NUnit.Framework;
using System;

namespace BowlingGameTests
{
    public class BowlingGameTests
    {
        Game game = new Game();

        [SetUp]
        public void SetUpGame()
        {
            game = new Game();
        }

        public void rollMany(int numberOfRolls, int pinsFall)
        {
            for(int i = 0; i < numberOfRolls; i++)
            {
                game.Roll(pinsFall);
            }
        }


        [Test]
        public void gutterGame()
        {
            rollMany(20, 0);
            Assert.AreEqual(0, game.Score());
        }

        [Test]
        public void rollAllOnes()
        {
            rollMany(20, 1);
            Assert.AreEqual(20, game.Score());
        }

        [Test]
        public void rollOneSpare()
        {
            game.Roll(5);
            game.Roll(5);
            game.Roll(3);
            rollMany(17, 0);
            Assert.AreEqual(16, game.Score());
        }

        [Test]
        public void rollOneStrike()
        {
            game.Roll(10);
            game.Roll(3);
            game.Roll(4);
            rollMany(16, 0);
            Assert.AreEqual(24, game.Score());
        }


        [Test]
        public void perfectGame()
        {
            rollMany(12, 10);
            Assert.AreEqual(300, game.Score());
        }


    }
}
