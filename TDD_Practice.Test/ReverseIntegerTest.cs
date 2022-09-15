using NUnit.Framework;
using TDD_Pracitce;

namespace TDD_Practice.Test
{
    public class ReverseIntegerTest
    {
        [Test]
        public void GIVEN_number___WHEN_reverse___THEN_reversed_number()
        {
            ReverseNumberEqual(1, 1);
            ReverseNumberEqual(-1, -1);
            ReverseNumberEqual(0, 0);
            ReverseNumberEqual(12, 21);
            ReverseNumberEqual(-12, -21);
            ReverseNumberEqual(123, 321);
            ReverseNumberEqual(-123, -321);
            ReverseNumberEqual(1234, 4321);
            ReverseNumberEqual(123456, 654321);
            ReverseNumberEqual(-123456, -654321);
            ReverseNumberEqual(123456789, 987654321);
            ReverseNumberEqual(1534236469, 0);
            ReverseNumberEqual(-2147483648, 0);
        }

        private static void ReverseNumberEqual(int targetNumber, int expectedNumber)
        {
            Assert.AreEqual(expectedNumber, ReverseInteger.Reverse(targetNumber));
        }
    }
}