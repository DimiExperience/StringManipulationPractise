using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrUtilities;

namespace UtilTest
{
    [TestClass]
    public class StringUtilsTest
    {
        [TestMethod]
        public void GetWordCount()
        {
            var inputString = "Petar petrovic. dr. petar petrovic. bio je car!";
            var input = new StringUtils(inputString);
            var expected = 8;
            var actual = input.GetWordCount();

            Assert.AreEqual(expected, actual, 0, "Word count is not correct!");
        }

        [TestMethod]
        public void GetReverseString()
        {
            var inputString = "Petar petrovic. dr. petar petrovic. bio je car!";
            var input = new StringUtils(inputString);
            var expected = "!rac ej oib .civortep ratep .rd .civortep rateP";
            var actual = input.GetReverseString();

            Assert.AreEqual(expected, actual, "Failed reversing string!");
        }

        [TestMethod]
        public void GetReverseWords()
        {
            var inputString = "Petar petrovic. dr. petar petrovic. bio je car!";
            var input = new StringUtils(inputString);
            var expected = "car! je bio petrovic. petar dr. petrovic. Petar";
            var actual = input.GetReverseWords();

            Assert.AreEqual(expected, actual, "Failed reversing words!");
        }

        [TestMethod]
        public void GetDiscreetChar()
        {
        }

        [TestMethod]
        public void GetSentenceCount()
        {
            var inputString = "Petar petrovic. dr. petar petrovic. bio je car!";
            var input = new StringUtils(inputString);
            var expected = 3;
            var actual = input.GetSentenceCount();

            Assert.AreEqual(expected, actual, 0, "Sentance count is not correct!");
        }

        [TestMethod]
        public void GetCharCount()
        {
            var inputString = "Petar petrovic. dr. petar petrovic. bio je car!";
            var input = new StringUtils(inputString);
            var expected = 3;
            var actual = input.GetCharCount('p');

            Assert.AreEqual(expected, actual, 0, "Word count is not correct!");
        }
    }
}
