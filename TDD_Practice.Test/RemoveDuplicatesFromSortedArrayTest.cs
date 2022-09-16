using NUnit.Framework;

namespace TDD_Practice.Test
{
    internal class RemoveDuplicatesFromSortedArrayTest
    {
        [Test]
        public void GIVEN_integer_array___THEN_remove_duplicate_number()
        {
            RemoveDuplicateCountEqual(GenerateArray(1, 2, 2), 2);
            RemoveDuplicateCountEqual(GenerateArray(1), 1);
            RemoveDuplicateCountEqual(GenerateArray(1, 2, 3, 4, 3, 3, 3, 4), 4);
        }

        private static int[] GenerateArray(params int[] values)
        {
            return values;
        }

        private static void RemoveDuplicateCountEqual(int[] nums, int expectedResult)
        {
            Assert.AreEqual(expectedResult, RemoveDuplicateHelper.RemoveDuplicates(nums));
        }
    }
}