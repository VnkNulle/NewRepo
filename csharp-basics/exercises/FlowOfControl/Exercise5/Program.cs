using System;

class PhoneKeyPad
{
    static void Main()
    {
        Console.Write("Enter the text: ");
        string inputText = Console.ReadLine().ToLower();

        string keypadDigits = "";
        foreach (char ch in inputText)
        {
            if (ch >= 'a' && ch <= 'z')
            {
                if (ch >= 'a' && ch <= 'c')
                    keypadDigits += "2";
                else if (ch >= 'd' && ch <= 'f')
                    keypadDigits += "3";
                else if (ch >= 'g' && ch <= 'i')
                    keypadDigits += "4";
                else if (ch >= 'j' && ch <= 'l')
                    keypadDigits += "5";
                else if (ch >= 'm' && ch <= 'o')
                    keypadDigits += "6";
                else if (ch >= 'p' && ch <= 's')
                    keypadDigits += "7";
                else if (ch >= 't' && ch <= 'v')
                    keypadDigits += "8";
                else if (ch >= 'w' && ch <= 'z')
                    keypadDigits += "9";
            }
            else
            {
                keypadDigits += ch;
            }
        }

        Console.WriteLine("Keypad digits: " + keypadDigits);
    }
}
