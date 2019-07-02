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
            for (int i = 0 ; i < 20; i++)
            {
                Roll(0);
            }
            
        }



    }
}
