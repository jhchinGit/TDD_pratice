using NUnit.Framework;

namespace TDD_Practice.Test
{
    internal class RemoveElementTest
    {
        [Test]
        public void GIVEN_array_and_value___WHEN_RemoveElement___THEN_return_number_of_not_value_item()
        {
            CountRemainingNumber(array: GenerateArray(1), removeValue: 1, remainingValueCount: 0);
            CountRemainingNumber(array: GenerateArray(0), removeValue: 1, remainingValueCount: 1);
            CountRemainingNumber(array: GenerateArray(0, 1), removeValue: 1, remainingValueCount: 1);
            CountRemainingNumber(array: GenerateArray(0, 1, 1), removeValue: 1, remainingValueCount: 1);
            CountRemainingNumber(array: GenerateArray(0, 1, 1), removeValue: 0, remainingValueCount: 2);
            CountRemainingNumber(array: GenerateArray(0, 1, 1), removeValue: 1, remainingValueCount: 1);
            CountRemainingNumber(array: GenerateArray(0, 1, 1), removeValue: 2, remainingValueCount: 3);
            CountRemainingNumber(array: GenerateArray(0, 1, 1, 2, 3), removeValue: 2, remainingValueCount: 4);
            CountRemainingNumber(array: GenerateArray(0, 1, 1, 2, 3), removeValue: 1, remainingValueCount: 3);
            CountRemainingNumber(array: GenerateArray(3, 2, 2, 3), removeValue: 3, remainingValueCount: 2);
            CountRemainingNumber(array: GenerateArray(0, 1, 2, 2, 3, 0, 4, 2), removeValue: 2, remainingValueCount: 5);
        }

        private static int[] GenerateArray(params int[] values)
        {
            return values;
        }

        private static void CountRemainingNumber(int[] array, int removeValue, int remainingValueCount)
        {
            Assert.AreEqual(remainingValueCount, RemoveElementHelper.RemoveElement(ref array, removeValue));
        }
    }
}