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
            ScoreShouldBe("Love_All");
        }

        [TestMethod]
        public void Thirty_All()
        {
            _tennis.firstplayerscoretime++;
            ScoreShouldBe("Thirty_All");
        }

        private void ScoreShouldBe(string expectedScore)
        {
            var score = _tennis.Score();
            Assert.AreEqual(expectedScore, score);
        }
    }
}