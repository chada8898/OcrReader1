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

        public string GetOcrDigit(int digit)
        {
            return OcrDigits[digit];
        }

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

        public int ParseNumber(string[] ocrdigits)
        {
            int number = 0;

            foreach (string ocrdigit in ocrdigits)
            {
                number *= 10;
                number += ParseDigit(ocrdigit);
            }

            return number;
        }

        public int ParseString(string ocrstring)
        {
            string[] ocrdigits = { "", "", "", "", "", "", "", "", "" };

            for (int line = 0; line < 3; line++)
            {
                for (int index = 0; index < 9; index++)
                {
                    ocrdigits[index] += ocrstring.Substring(line * 27 + index * 3, 3);
                }
            }

            return ParseNumber(ocrdigits);
        }

        public bool IsValidAccountNumber(int accountNumber)
        {
            int checksum = 0;

            for (int index = 1; index <= 9; index++)
            {
                checksum += index * (accountNumber % 10);
                accountNumber /= 10;
            }

            return (checksum % 11) == 0;
        }

    }
}
