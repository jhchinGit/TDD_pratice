using System.Linq;

namespace TDD_Practice
{
    public class RemoveDuplicateHelper
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int count = 0;

            for (int index = 0; index < nums.Length; index++)
            {
                bool isDuplicated = false;
                for (int x = index + 1; x < nums.Length; x++)
                {
                    if (nums[x] == nums[index])
                    {
                        isDuplicated = true;
                        break;
                    }
                }

                if (!isDuplicated)
                    nums[count++] = nums[index];
            }

            return count;
        }
    }
}