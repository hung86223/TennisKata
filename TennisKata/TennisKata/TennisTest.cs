using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisKata
{
    [TestClass]
    public class TennisTest
    {
        [TestMethod]
        public void Love_All()
        {
            var tennis = new Tennis();
            var score = tennis.Score();
            Assert.AreEqual("Love_All", score);
        }
    }
}