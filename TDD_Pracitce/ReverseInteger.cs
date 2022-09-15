using System;

namespace TDD_Pracitce
{
    public static class ReverseInteger
    {
        public static int Reverse(int number)
        {
            bool isPositiveNumber = number >= 0;
            var positiveNumber = isPositiveNumber ? number : number * -1;
            var numberString = positiveNumber.ToString();

            if (numberString.Length > 1)
            {
                int loopCount = (int)Math.Floor((decimal)numberString.Length / 2);
                int middleCount = (int)Math.Ceiling((decimal)numberString.Length / 2);
                for (int index = 1; index <= loopCount; index++)
                {
                    string head = numberString.Substring(0, index - 1);
                    string exchangeHead = numberString.Substring(index - 1, 1);

                    int middleLength = numberString.Length - middleCount - index + (numberString.Length % 2 == 0 ? 1 : 0);
                    string middle = numberString.Substring(index, middleLength);
                    middleCount += 1;
                    string exchangeTail = numberString.Substring(numberString.Length - index, 1);
                    string tail = numberString.Substring(numberString.Length - 1, index - 1);
                    numberString = head + exchangeTail + middle + exchangeHead + tail;
                }

                var result = int.Parse(numberString);
                return isPositiveNumber ? result : result * -1;
            }
            else
            {
                return number;
            }
        }
    }
}