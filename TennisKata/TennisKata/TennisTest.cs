using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisKata
{
    [TestClass]
    public class TennisTest
    {
        private readonly Tennis _tennis = new Tennis();

        [TestMethod]
        public void Love_All()
        {
            var score = _tennis.Score();
            Assert.AreEqual("Love_All", score);
        }

        [TestMethod]
        public void Thirty_All()
        {
            _tennis.firstplayerscoretime++;
            var score = _tennis.Score();
            Assert.AreEqual("Thirty_All", score);
        }
    }
}