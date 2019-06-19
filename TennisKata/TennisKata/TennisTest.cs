using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisKata
{
    [TestClass]
    public class TennisTest
    {
        private readonly Tennis _tennis = new Tennis("Ben");

        [TestMethod]
        public void Love_All()
        {
            ScoreShouldBe("Love_All");
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            _tennis.PlayerScored("first", 1);
            ScoreShouldBe("Fifteen_Love");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            _tennis.PlayerScored("first", 2);
            ScoreShouldBe("Thirty_Love");
        }

        [TestMethod]
        public void Forty_Love()
        {
            _tennis.PlayerScored("first", 3);

            ScoreShouldBe("Forty_Love");
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            _tennis.PlayerScored("second", 1);

            ScoreShouldBe("Love_Fifteen");
        }

        [TestMethod]
        public void Love_Thirty()
        {
            _tennis.PlayerScored("second", 2);

            ScoreShouldBe("Love_Thirty");
        }

        [TestMethod]
        public void Love_Forty()
        {
            _tennis.PlayerScored("second", 3);

            ScoreShouldBe("Love_Forty");
        }

        [TestMethod]
        public void Fifteen_All()
        {
            _tennis.PlayerScored("first", 1);
            _tennis.PlayerScored("second", 1);

            ScoreShouldBe("Fifteen_All");
        }

        [TestMethod]
        public void Thirty_All()
        {
            _tennis.PlayerScored("first", 2);
            _tennis.PlayerScored("second", 2);

            ScoreShouldBe("Thirty_All");
        }

        [TestMethod]
        public void Thirty_Fifteen()
        {
            _tennis.PlayerScored("first", 2);
            _tennis.PlayerScored("second", 1);

            ScoreShouldBe("Thirty_Fifteen");
        }

        [TestMethod]
        public void Thirty_Forty()
        {
            _tennis.PlayerScored("first", 2);
            _tennis.PlayerScored("second", 3);

            ScoreShouldBe("Thirty_Forty");
        }

        [TestMethod]
        public void Forty_Fifteen()
        {
            _tennis.PlayerScored("first", 3);
            _tennis.PlayerScored("second", 1);

            ScoreShouldBe("Forty_Fifteen");
        }

        [TestMethod]
        public void Forty_Thirty()
        {
            _tennis.PlayerScored("first", 3);
            _tennis.PlayerScored("second", 2);

            ScoreShouldBe("Forty_Thirty");
        }

        [TestMethod]
        public void Deuce()
        {
            _tennis.PlayerScored("first", 3);
            _tennis.PlayerScored("second", 3);

            ScoreShouldBe("Deuce");
        }

        [TestMethod]
        public void FirstPlayer_adv()
        {
            _tennis.PlayerScored("first", 4);
            _tennis.PlayerScored("second", 3);

            ScoreShouldBe("Ben_adv");
        }

        private void ScoreShouldBe(string expectedScore)
        {
            var score = _tennis.Score();
            Assert.AreEqual(expectedScore, score);
        }
    }
}