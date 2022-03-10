using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bowling.UnitTest
{
    [TestClass]
    public class FrameTests
    {
        Round r;

        public FrameTests()
        {
            r = new Round();
        }

        private void RollBalls(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                r.Roll(pins);
            }
        }

        [TestMethod]
        public void OneGutterBall()
        {
            RollBalls(1, 0);
            Assert.AreEqual(0, r.Score());
        }

        [TestMethod]
        public void AllGutterBalls()
        {
            RollBalls(20, 0);
            Assert.AreEqual(0, r.Score());
        }

        [TestMethod]
        public void TwentyOnePinBalls()
        {
            RollBalls(20, 1);
            Assert.AreEqual(20, r.Score());
        }

        [TestMethod]
        public void OneSpare()
        {
            r.Roll(9);
            r.Roll(1);
            r.Roll(2);
            RollBalls(17, 0);
            // 9 + 1 + 2 + 2 = 14
            Assert.AreEqual(14, r.Score());
        }

        [TestMethod]
        public void OneStrike()
        {
            r.Roll(10);
            r.Roll(5);
            r.Roll(3);
            RollBalls(16, 0);
            // 10 + 5 + 3 + 5 + 3 = 26
            Assert.AreEqual(26, r.Score());
        }

        [TestMethod]
        public void AllStrikes()
        {
            RollBalls(12, 10);
            // max points 300
            Assert.AreEqual(300, r.Score());
        }
    }
}
