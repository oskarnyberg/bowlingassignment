using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bowling.UnitTest
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void CreatePlayerName()
        {
            var player = new Player("RobinHood");
            Assert.AreEqual("RobinHood", player.Name);
        }

        [TestMethod]
        public void CreatePlayerScore()
        {
            var player = new Player("RobinHood");
            Assert.AreEqual(0, player.Round.Score());
        }
    }
}
