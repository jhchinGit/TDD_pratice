﻿using System;

namespace TDD_Pracitce
{
    public static class ReverseInteger
    {
        public static int Reverse(int x)
        {
            if (x == int.MaxValue || x == int.MinValue)
                return 0;

            bool isPositiveNumber = x >= 0;
            var positiveNumber = isPositiveNumber ? x : x * -1;
            var numberString = positiveNumber.ToString();

            if (numberString.Length > 1)
            {
                int loopCount = (int)Math.Floor((decimal)numberString.Length / 2);
                for (int index = 1; index <= loopCount; index++)
                {
                    string head = numberString.Substring(0, index - 1);
                    string exchangeHead = numberString.Substring(index - 1, 1);

                    int backLength = numberString.Length - (numberString.Length - index);
                    int headLength = numberString.Length - index;
                    int middleLength = headLength - backLength;
                    string middle = numberString.Substring(index, middleLength);

                    string exchangeTail = numberString.Substring(numberString.Length - index, 1);
                    string tail = numberString.Substring(numberString.Length - index + 1, index - 1);
                    numberString = head + exchangeTail + middle + exchangeHead + tail;
                }

                var result = long.Parse(numberString);
                result = isPositiveNumber ? result : result * -1;

                if (!int.TryParse(result.ToString(), out var longResult))
                    return 0;

                return (int)result;
            }

            return x;
        }
    }
}