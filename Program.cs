using System;
using System.Reflection;
using System.IO;

namespace OcrReader1
{
    class Program
    {
        [STAThread]
        static int Main(string[] args)
        {
            const string filename = @"..\..\accounts.txt";
            string[] my_args = { Assembly.GetExecutingAssembly().Location };

            int returnCode = NUnit.ConsoleRunner.Runner.Main(my_args);
            if (returnCode != 0)
            {
                Console.Beep();
                Console.ReadLine();
                return 1;
            }

            // Open file & read lines into strings
            try
            {
                using (StreamReader reader = File.OpenText(filename))
                {
                    string buffer = null;
                    var ocrReader = new OcrReader();

                    do
                    {
                        string ocrstring = "";

                        for (int index = 0; index < 3; index++)
                        {
                            if ((buffer = reader.ReadLine()) != null)
                            {
                                ocrstring += buffer.Substring(0, 27);
                            }
                            else break;
                        }

                        if (buffer != null)
                        {
                            buffer = reader.ReadLine();
                            int accountNumber = ocrReader.ParseString(ocrstring);
                            Console.WriteLine("Account number = " + accountNumber + "  Valid number = " + ocrReader.IsValidAccountNumber(accountNumber));
                        }

                    } while (buffer != null);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error reading file " + filename);
            }

            Console.ReadLine();
            return 0;
        }
    }
}
