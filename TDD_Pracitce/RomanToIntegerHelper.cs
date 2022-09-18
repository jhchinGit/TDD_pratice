using System.Collections.Generic;

namespace TDD_Practice
{
    public class RomanToIntegerHelper
    {
        private static readonly Dictionary<char, int> RomanDictioary = new()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        public static int RomanToInt(string roman)
        {
            int total = 0;

            int previousNumber = 0;
            for (int index = 0; index < roman.Length; index++)
            {
                int currentNumber = RomanDictioary[roman[index]];

                if (previousNumber >= currentNumber)
                {
                    if (IsThisLastNumber(roman, index))
                    {
                        total += previousNumber + currentNumber;
                        previousNumber = 0;
                    }
                    else
                    {
                        total += previousNumber;
                        previousNumber = currentNumber;
                    }
                }
                else if (previousNumber != 0 && previousNumber < currentNumber)
                {
                    total += currentNumber - previousNumber;
                    previousNumber = 0;
                }
                else if (IsThisLastNumber(roman, index))
                {
                    total += currentNumber;
                }
                else
                {
                    previousNumber = currentNumber;
                }
            }

            return total;
        }

        private static bool IsThisLastNumber(string roman, int index)
        {
            return index + 1 == roman.Length;
        }
    }
}