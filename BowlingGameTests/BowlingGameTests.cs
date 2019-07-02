using BowlingGame;
using NUnit.Framework;
using System;

namespace BowlingGameTests
{
    public class BowlingGameTests
    {
        [Test]
        public void createGame()
        {
            Game game = new Game();
        }

        [Test]
        public void GutterGame()
        {
            Game game = new Game();

            for (int i = 0 ; i < 20; i++)
            {
                game.Roll(0);
            }
            
            Assert.AreEqual(0, )
        }



    }
}
