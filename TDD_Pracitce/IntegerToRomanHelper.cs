using System.Collections.Generic;

namespace TDD_Practice
{
    public class IntegerToRomanHelper
    {

        private static readonly Dictionary<int, string> RomanDictioary = new()
        {
            { 1, "I" },
            { 5, "V" },
            { 10, "X" },
            { 50, "L" },
            { 100, "C" },
            { 500, "D" },
            { 1000, "M" }
        };

        public static string IntToRoman(int number)
        {
            string roman = "";
            if (RomanDictioary.ContainsKey(number))
            {
                roman = RomanDictioary[number];
            }
            else if (number < 10)
            {
                for (int index = 0; index < number; index++)
                {
                    if (index == 4)
                    {
                        roman = RomanDictioary[5];
                    }
                    else if (index == 3)
                    {
                        roman = RomanDictioary[1] + RomanDictioary[5];
                    }
                    else if (index == 5)
                    {
                        roman = RomanDictioary[5] + RomanDictioary[1];
                    }
                    else
                    {
                        roman += RomanDictioary[1];
                    }
                }
            }
            else if (number < 99)
            {
                for (int index = 0; index < number; index++)
                {
                    if (index == 49)
                    {
                        roman = RomanDictioary[number];
                    }
                    else
                    {
                        roman += RomanDictioary[1];
                    }
                }
            }

            return roman;
        }
    }
}