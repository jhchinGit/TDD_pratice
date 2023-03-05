using System;

namespace TDD_Practice
{
    public class RotateArray
    {
        public static void Rotate(int[] nums, int k)
        {
            if (k <= 0 || nums.Length == 0)
            {
                return;
            }

            while(k > 0)
            {
                bool isLargeRotate = false;
                if (k > nums.Length)
                {
                    isLargeRotate = true;
                }

                int tempK = isLargeRotate ? nums.Length : k;

                int[] tempArray = new int[tempK];

                Array.Copy(nums, nums.Length - tempK, tempArray, 0, tempK);
                Array.Copy(nums, 0, nums, tempK, nums.Length - tempK);
                Array.Copy(tempArray, 0, nums, 0, tempArray.Length);

                k -= nums.Length;
            }
        }
    }
}