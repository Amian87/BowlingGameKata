using BowlingGame;
using NUnit.Framework;
using System;

namespace BowlingGameTests
{
    public class BowlingGameTests
    {
        Game game;

        [SetUp]
        public void SetupGame()
        {
            game = new Game();

        }

        public void RollMany(int numberOfrRolls, int pinsHitPerRoll)
        {
            for (int i = 0; i < numberOfrRolls; i++ )
            {
                game.Rolls(pinsHitPerRoll);
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

    }
}
