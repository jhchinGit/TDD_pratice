using NUnit.Framework;

namespace TDD_Practice.Test
{
    internal class RomanToIntegerTest
    {
        [Test]
        public void GIVEN_roman_words___WHEN_roman_to_arabic___THEN_equal_value_with_arabic()
        {
            ValueEqualToRomanCharacters("I", 1);
            ValueEqualToRomanCharacters("V", 5);
            ValueEqualToRomanCharacters("X", 10);
            ValueEqualToRomanCharacters("L", 50);
            ValueEqualToRomanCharacters("C", 100);
            ValueEqualToRomanCharacters("D", 500);
            ValueEqualToRomanCharacters("M", 1000);
            ValueEqualToRomanCharacters("III", 3);
            ValueEqualToRomanCharacters("IV", 4);
            ValueEqualToRomanCharacters("VI", 6);
            ValueEqualToRomanCharacters("LVIII", 58);
            ValueEqualToRomanCharacters("XIX", 19);
            ValueEqualToRomanCharacters("MCMXCIV", 1994);
            ValueEqualToRomanCharacters("MCMXCVI", 1996);
        }

        private static void ValueEqualToRomanCharacters(string roman, int number)
        {
            Assert.AreEqual(number, RomanToIntegerHelper.RomanToInt(roman));
        }
    }
}