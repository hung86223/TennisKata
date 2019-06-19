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
        public void Fifteen_Love()
        {
            _tennis.FirstPlayerScored();
            ScoreShouldBe("Fifteen_Love");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            _tennis.FirstPlayerScored();
            _tennis.FirstPlayerScored();
            ScoreShouldBe("Thirty_Love");
        }

        [TestMethod]
        public void Forty_Love()
        {
            _tennis.FirstPlayerScored();
            _tennis.FirstPlayerScored();
            _tennis.FirstPlayerScored();
            ScoreShouldBe("Forty_Love");
        }

        [TestMethod]
        public void Fifteen_All()
        {
            _tennis.FirstPlayerScored();
            _tennis.FirstPlayerScored();
            _tennis.FirstPlayerScored();
            ScoreShouldBe("Fifteen_All");
        }

        private void ScoreShouldBe(string expectedScore)
        {
            var score = _tennis.Score();
            Assert.AreEqual(expectedScore, score);
        }
    }
}