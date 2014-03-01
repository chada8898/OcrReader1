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
            string ocrDigit7 = " _ "
                             + "  |"
                             + "  |";

            Assert.AreEqual(7, ocrReader.ParseDigit(ocrDigit7));
        }
    }
}
