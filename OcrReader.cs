using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OcrReader1
{
    class OcrReader
    {
        private string[] OcrDigits =  
        {
           " _ " +
           "| |" +
           "|_|",

           "   " +
           "  |" +
           "  |",

           " _ " +
           " _|" +
           "|_ ",

           " _ " +
           " _|" +
           " _|",

           "   " +
           "|_|" +
           "  |",

           " _ " +
           "|_ " +
           " _|",

           " _ " +
           "|_ " +
           "|_|",

           " _ " +
           "  |" +
           "  |",

           " _ " +
           "|_|" +
           "|_|",

           " _ " +
           "|_|" +
           " _|"
        };

        public int ParseDigit(string ocrdigit)
        {
            for (int index = 0; index < 10; index++ )
            {
                if (OcrDigits[index].Equals(ocrdigit))
                {
                    return index;
                }
            }

            return -1;
        }
    }
}
