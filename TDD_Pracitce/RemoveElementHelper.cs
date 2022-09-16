namespace TDD_Practice
{
    public class RemoveElementHelper
    {
        public static int RemoveElement(ref int[] arrayToRemove, int valueToRemove)
        {
            int count = 0;
            for (int index = 0; index < arrayToRemove.Length; index++)
                if (arrayToRemove[index] != valueToRemove)
                    arrayToRemove[count++] = arrayToRemove[index];

            return count;
        }
    }
}