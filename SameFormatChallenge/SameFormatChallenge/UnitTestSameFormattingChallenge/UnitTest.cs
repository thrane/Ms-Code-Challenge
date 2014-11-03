using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestChallenge
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestFormatNumber()
        {
            var sut = new SameFormattingChallenge.Challenge();

            const decimal inputNumber = 4563111.45M;

            Thread.CurrentThread.CurrentCulture = new CultureInfo("da-DK"); //We are in Denmark
            Assert.AreEqual("4x563x111y45000", sut.FormatNumber(inputNumber));

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US"); //We are in USA
            Assert.AreEqual("4x563x111y45000", sut.FormatNumber(inputNumber));
        }

        [TestMethod]
        public void TestFormatDate()
        {
            var sut = new SameFormattingChallenge.Challenge();

            var inputDate = new DateTime(1900, 12, 1);

            Thread.CurrentThread.CurrentCulture = new CultureInfo("da-DK"); //We are in Denmark
            Assert.AreEqual("December-1900-01", sut.FormatDate(inputDate));

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US"); //We are in USA
            Assert.AreEqual("December-1900-01", sut.FormatDate(inputDate));
        }

        [TestMethod]
        public void TestInternal()
        {
            var sut = new SameFormattingChallenge.Challenge();

            const decimal inputNumber = 4563111.45M;

            Thread.CurrentThread.CurrentCulture = new CultureInfo("da-DK"); //We are in Denmark
            Assert.AreEqual("4x563x111y45000", sut.FormatNumber(inputNumber));

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US"); //We are in USA
            Assert.AreEqual("4x563x111y45000", sut.FormatNumber(inputNumber));

            const decimal inputNumber2 = 1563111.451M;

            Thread.CurrentThread.CurrentCulture = new CultureInfo("da-DK"); //We are in Denmark
            Assert.AreEqual("1x563x111y45100", sut.FormatNumber(inputNumber2));

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US"); //We are in USA
            Assert.AreEqual("1x563x111y45100", sut.FormatNumber(inputNumber2));


            var inputDate = new DateTime(1900, 12, 1);

            Thread.CurrentThread.CurrentCulture = new CultureInfo("da-DK"); //We are in Denmark
            Assert.AreEqual("December-1900-01", sut.FormatDate(inputDate));

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US"); //We are in USA
            Assert.AreEqual("December-1900-01", sut.FormatDate(inputDate));

            var inputDate2 = new DateTime(1900, 1, 1);

            Thread.CurrentThread.CurrentCulture = new CultureInfo("da-DK"); //We are in Denmark
            Assert.AreEqual("January-1900-01", sut.FormatDate(inputDate2));

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US"); //We are in USA
            Assert.AreEqual("January-1900-01", sut.FormatDate(inputDate2));
        }

    }
}
