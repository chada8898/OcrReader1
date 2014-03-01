using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace OcrReader1
{
    [TestFixture]
    public class TestFixture1
    {
        [Test]
        public void TestParseDigit()
        {
            var ocrReader = new OcrReader();

            string ocrDigit1 = "   "
                             + "  |"
                             + "  |";
            Assert.AreEqual(1, ocrReader.ParseDigit(ocrDigit1));

            string ocrDigit7 = " _ "
                             + "  |"
                             + "  |";
            Assert.AreEqual(7, ocrReader.ParseDigit(ocrDigit7));

            string ocrDigit0 = " _ "
                             + "| |"
                             + "|_|";
            Assert.AreEqual(0, ocrReader.ParseDigit(ocrDigit0));

            string ocrDigit3 = " _ "
                             + " _|"
                             + " _|";
            Assert.AreEqual(3, ocrReader.ParseDigit(ocrDigit3));

            string ocrDigit2 = " _ "
                             + " _|"
                             + "|_ ";
            Assert.AreEqual(2, ocrReader.ParseDigit(ocrDigit2));

            string ocrDigit5 = " _ "
                             + "|_ "
                             + " _|";
            Assert.AreEqual(5, ocrReader.ParseDigit(ocrDigit5));

            string ocrDigit6 = " _ "
                             + "|_ "
                             + "|_|";
            Assert.AreEqual(6, ocrReader.ParseDigit(ocrDigit6));

            string ocrDigit8 = " _ "
                             + "|_|"
                             + "|_|";
            Assert.AreEqual(8, ocrReader.ParseDigit(ocrDigit8));

            string ocrDigit9 = " _ "
                             + "|_|"
                             + " _|";
            Assert.AreEqual(9, ocrReader.ParseDigit(ocrDigit9));

            string ocrDigit4 = "   "
                             + "|_|"
                             + "  |";
            Assert.AreEqual(4, ocrReader.ParseDigit(ocrDigit4));
        }
    }
}
