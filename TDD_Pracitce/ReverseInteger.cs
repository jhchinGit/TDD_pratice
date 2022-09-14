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
                for (int index = 0; index < numberString.Length; index++)
                {
                    string middle = numberString.Substring(index + 1, numberString.Length - index - 1);
                    numberString = numberString[]
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