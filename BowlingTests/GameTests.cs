using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bowling.UnitTest
{
    [TestClass]
    public class GameTests
    {
        BowlingGame game;

        public GameTests()
        {
            List<string> players = new List<string> { "RobinHood", "Palpatine" };
            game = new BowlingGame(players);
        }

        [TestMethod]
        public void RollOneBallNoChangePlayer()
        {
            game.Roll(9);
            Assert.AreEqual("RobinHood", game.currentPlayer.Name);
        }

        [TestMethod]
        public void RollTwoBallsChangePlayer()
        {
            game.Roll(9);
            game.Roll(0);
            Assert.AreEqual("Palpatine", game.currentPlayer.Name);
        }

        [TestMethod]
        public void RollStrikeChangePlayer()
        {
            game.Roll(10);
            Assert.AreEqual("Palpatine", game.currentPlayer.Name);
        }
    }
}
