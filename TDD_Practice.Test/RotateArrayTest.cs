using NUnit.Framework;

namespace TDD_Practice.Test
{
    internal class RotateArrayTest
    {
        [Test]
        public void TestRotateArray()
        {
            RotateArrayEqual(GenerateArray(1, 2, 3, 4, 5, 6, 7), 3, GenerateArray(5, 6, 7, 1, 2, 3, 4));
        }

        private static int[] GenerateArray(params int[] values)
        {
            return values;
        }

        private static void RotateArrayEqual(int[] nums, int rotate, int[] expectedResult)
        {
            RotateArray.Rotate(nums, rotate);
            CollectionAssert.AreEqual(expectedResult, nums);
        }
    }
}