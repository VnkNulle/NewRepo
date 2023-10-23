using System;

class PhoneKeyPad2
{
    static void Main()
    {
        Console.Write("Enter the text: ");
        string inputText = Console.ReadLine().ToLower();

        string keypadDigits = "";
        foreach (char ch in inputText)
        {
            switch (ch)
            {
                case 'a':
                case 'b':
                case 'c':
                    keypadDigits += "2";
                    break;
                case 'd':
                case 'e':
                case 'f':
                    keypadDigits += "3";
                    break;
                case 'g':
                case 'h':
                case 'i':
                    keypadDigits += "4";
                    break;
                case 'j':
                case 'k':
                case 'l':
                    keypadDigits += "5";
                    break;
                case 'm':
                case 'n':
                case 'o':
                    keypadDigits += "6";
                    break;
                case 'p':
                case 'q':
                case 'r':
                case 's':
                    keypadDigits += "7";
                    break;
                case 't':
                case 'u':
                case 'v':
                    keypadDigits += "8";
                    break;
                case 'w':
                case 'x':
                case 'y':
                case 'z':
                    keypadDigits += "9";
                    break;
                default:
                    keypadDigits += ch;
                    break;
            }
        }

        Console.WriteLine("Keypad digits: " + keypadDigits);
    }
}
