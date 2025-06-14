using System;
using System.Collections.Generic;
using System.Text;

public class OldPhone
{
    private static readonly Dictionary<char, string> keyMap = new Dictionary<char, string>()
    {
        { '1', "&'(" },  // 
        { '2', "ABC" },
        { '3', "DEF" },
        { '4', "GHI" },
        { '5', "JKL" },
        { '6', "MNO" },
        { '7', "PQRS" },
        { '8', "TUV" },
        { '9', "WXYZ" },
        { '0', " " }
    };

    public static string OldPhonePad(string input)
    {
        StringBuilder output = new StringBuilder();
        char lastChar = '\0';
        int count = 0;

        for (int i = 0; i < input.Length; i++)
        {
            char current = input[i];

            if (current == '#')
            {
                if (lastChar != '\0')
                {
                    output.Append(GetLetter(lastChar, count));
                }
                break;
            }
            else if (current == '*')
            {
                if (lastChar != '\0')
                {
                    lastChar = '\0';
                    count = 0;
                }
                else if (output.Length > 0)
                {
                    output.Length--; // backspace
                }
            }
            else if (current == ' ')
            {
                if (lastChar != '\0')
                {
                    output.Append(GetLetter(lastChar, count));
                    lastChar = '\0';
                    count = 0;
                }
            }
            else if (Char.IsDigit(current))
            {
                if (current == lastChar)
                {
                    count++;
                }
                else
                {
                    if (lastChar != '\0')
                    {
                        output.Append(GetLetter(lastChar, count));
                    }
                    lastChar = current;
                    count = 1;
                }
            }
        }

        return output.ToString();
    }

    private static char GetLetter(char digit, int count)
    {
        if (!keyMap.ContainsKey(digit))
            return '?';

        string letters = keyMap[digit];
        int index = (count - 1) % letters.Length;
        return letters[index];
    }
}
