namespace TDD_Practice
{
    public class RemoveElementHelper
    {
        public static int RemoveElement(ref int[] arrayToRemove, int valueToRemove)
        {
            int count = 0, newIndexCount = 0;
            int[] newArray = new int[arrayToRemove.Length];
            for (int index = 0; index < arrayToRemove.Length; index++)
                if (arrayToRemove[index] != valueToRemove)
                {
                    newArray[newIndexCount++] = arrayToRemove[index];
                    count++;
                }

            int swapIndex = 0;
            for (int index = 0; index < arrayToRemove.Length; index++)
            {
                for (int x = index, y = 0; y < arrayToRemove.Length; y++)
                {

                }
            }

            arrayToRemove = newArray;
            return count;
        }
    }
}