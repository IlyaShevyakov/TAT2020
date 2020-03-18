using System;
using DEV_1._2;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace NumberConverterTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow("10", "A")]
        [DataRow("11", "B")]
        [DataRow("12", "C")]
        [DataRow("13", "D")]
        [DataRow("14", "E")]
        [DataRow("15", "F")]
        [DataRow("16", "G")]
        [DataRow("17", "H")]
        [DataRow("18", "I")]
        [DataRow("19", "J")]
        public void DivisorGreaterThanNineTest(string number, string expected)
        {
            Assert.AreEqual(expected, NumberConverter.DivisorGreaterThanNine(number));
        }
        [TestMethod]
        [DataTestMethod]
        [DataRow(10, 2, "1010")]
        [DataRow(10, 3, "101")]
        [DataRow(10, 4, "22")]
        [DataRow(10, 5, "20")]
        [DataRow(10, 6, "14")]
        [DataRow(10, 7, "13")]
        [DataRow(10, 8, "12")]
        [DataRow(10, 9, "11")]
        [DataRow(10, 10, "10")]
        [DataRow(10, 11, "A")] 
        [DataRow(10, 12, "A")]
        [DataRow(11, 13, "B")]
        [DataRow(12, 14, "C")]
        [DataRow(13, 15, "D")]
        [DataRow(14, 16, "E")]
        [DataRow(15, 17, "F")]
        [DataRow(16, 18, "G")]
        [DataRow(17, 19, "H")]
        [DataRow(18, 20, "I")]
        public void TransferToNewSystem(int number, int system, string expected)
        {
            NumberConverter systemNumber =
                new NumberConverter(number, system);
            Assert.AreEqual(expected, systemNumber.TransferToNewSystem());
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckLessThenTwo()
        {
            NumberConverter systemNumber = new NumberConverter(10, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CheckMoreThenTwenty()
        {
            NumberConverter systemNumber = new NumberConverter(10, 22);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NumberLessThenZero()
        {
            NumberConverter systemNumber = new NumberConverter(-10, 2);
        }

        
    }
}
