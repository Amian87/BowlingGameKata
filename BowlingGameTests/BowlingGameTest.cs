using BowlingGame;
using NUnit.Framework;
using System;

namespace BowlingGameTests
{
    
    public class BowlingGameTest
    {

        [Test]
        public void CreateGame()
        {
            Game g = new Game();
        }

        [Test]
        public void GutterGame()
        {
            Game g = new Game();

            for (int i = 0;  i < 20; i++)
            {
                g.Rolls(0);
            }

            Assert.AreEqual(0, g.Score());
        }

        [Test]
        public void RollAllOnes()
        {
            Game g = new Game();

            for (int i = 0; i < 20; i++)
            {
                g.Rolls(1);
            }

            Assert.AreEqual(20, g.Score());
        }

    

    }
}
