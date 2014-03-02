KataBankOCR
Chad Anderson 3/2/2014

Part 1: Read OCR account numbers from file accounts.txt.
Account numbers are displayed on stdout since the kata did not specify
where parsed account numbers should go (not specified in part 1 at least).

Caveats:

1. No error checking on the file format.
2. OcrReader.cs needs only one public method. All methods are public for tests.
3. Extra tests in TestFixture.cs are redundant and can be refactored out.
At the end of part one, the only test needed is TestParseString().
Leaving the redundant tests in since this is a practice exercise.


