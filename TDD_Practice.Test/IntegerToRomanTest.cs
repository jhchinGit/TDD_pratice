using NUnit.Framework;

namespace TDD_Practice.Test
{
    internal class IntegerToRomanTest
    {
        [Test]
        public void GIVEN_arabic_numbers___WHEN_arabic_to_roman___THEN_return_value_in_roman()
        {
            IntegerEqualRoman(1, "I");
            IntegerEqualRoman(5, "V");
            IntegerEqualRoman(10, "X");
            IntegerEqualRoman(50, "L");
            IntegerEqualRoman(100, "C");
            IntegerEqualRoman(500, "D");
            IntegerEqualRoman(1000, "M");
            IntegerEqualRoman(3, "III");
            IntegerEqualRoman(4, "IV");
            IntegerEqualRoman(6, "VI");
        }

        private static void IntegerEqualRoman(int number, string roman)
        {
            Assert.AreEqual(roman, IntegerToRomanHelper.IntToRoman(number));
        }
    }
}