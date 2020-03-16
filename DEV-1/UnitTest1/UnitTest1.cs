using Microsoft.VisualStudio.TestTools.UnitTesting;
using  DEV_1;
using System;

namespace DEV_1.Test
{
    [TestClass()]
    public class LineTest
    {
        [TestMethod()]
        public void IsLineEmptyTure()
        {
            DEV_1.Line word = new DEV_1.Line("");

            bool actual = word.IsLineEmpty();

            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsLineEmptyFalse()
        {
            Line word = new Line("abcd");

            bool actual = word.IsLineEmpty();

            Assert.IsFalse(actual);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckValueNullTest()
        {
            Line symbols = new Line(null);
        }
        [TestMethod()]
        public void EmptyLineNumberOfNonRepeatingSymbolsTest()
        {
            Line word = new Line("");
            int expected = 0;

            int actual = word.NonRepeatingSymbols();

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void NumberOfNonRepeatingSymbolsTest()
        {
            Line word = new Line("abccefgh");
            int expected = 5;

            int actual = word.NonRepeatingSymbols();

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void SameSymblosNumberOfNonRepeatingSymbolsTest()
        {
            Line word = new Line("aaaaa");
            int expected = 1;

            int actual = word.NonRepeatingSymbols();

            Assert.AreEqual(actual, expected);
        }
    }
}
