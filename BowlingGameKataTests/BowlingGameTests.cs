using NUnit.Framework;
using BowlingGame;

namespace BowlingGameKataTests
{
    public class BowlingGameTests
    {
        public Game game;

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
            RollManyTimes(16, 0);
            Assert.AreEqual(24, game.Score());
        }

        [Test]
        public void PerfectGame()
        {
            RollManyTimes(20, 10);
            Assert.AreEqual(300, game.Score());
        }
    }
}
