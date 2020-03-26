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
            NumberOfDifferentSymbols word = new NumberOfDifferentSymbols("");

            bool actual = word.IsLineEmpty();

            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsLineEmptyFalse()
        {
            NumberOfDifferentSymbols word = new NumberOfDifferentSymbols("abcd");

            bool actual = word.IsLineEmpty();

            Assert.IsFalse(actual);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckValueNullTest()
        {
            NumberOfDifferentSymbols symbols = new NumberOfDifferentSymbols(null);
        }
        [TestMethod()]
        public void EmptyLineNumberOfNonRepeatingSymbolsTest()
        {
            NumberOfDifferentSymbols word = new NumberOfDifferentSymbols("");
            int expected = 0;

            int actual = word.NumberNonRepeatingCharacter();

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void NumberOfNonRepeatingSymbolsTest()
        {
            NumberOfDifferentSymbols word = new NumberOfDifferentSymbols("abccefgh");
            int expected = 5;

            int actual = word.NumberNonRepeatingCharacter();

            Assert.AreEqual(actual, expected);
        }

        
    }
}
