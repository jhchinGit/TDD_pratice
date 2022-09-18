using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace TDD_Practice.Test
{
    internal class ThreeSumTest
    {
        /// <summary>
        /// https://leetcode.com/problems/3sum/
        /// Yet to resolve, failing reason is time exceeded
        /// </summary>
        [Test]
        public void GIVEN_number_array___WHEN_three_sum___THEN_return_array_with_sum_in_zero()
        {
            AssertThreeSumAreEqual(GenerateArray(0, 1, 1), GenerateList());
            AssertThreeSumAreEqual(GenerateArray(0, 0, 0), GenerateList(0, 0, 0));
            AssertThreeSumAreEqual(GenerateArray(0, -1, 1), GenerateList(0, -1, 1));
            AssertThreeSumAreEqual(GenerateArray(0, -1, 2), GenerateList());
            AssertThreeSumAreEqual(GenerateArray(0, -1, -1, 2), GenerateList(-1, -1, 2));
            var list = GenerateList(-1, -1, 2);
            list.Add(GenerateList(-1, 0, 1)[0]);
            AssertThreeSumAreEqual(GenerateArray(-1, 0, 1, 2, -1, -4), list);
        }

        private static IList<IList<int>> GenerateList(params int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return new List<IList<int>>();
            }
            else
            {
                return new List<IList<int>>
                {
                    numbers.OrderBy(n => n).ToList()
                };
            }
        }

        private static int[] GenerateArray(params int[] numbers)
        {
            return numbers;
        }

        private static void AssertThreeSumAreEqual(int[] targetArray, IList<IList<int>> expectedResult)
        {
            CollectionAssert.AreEqual(expectedResult, ThreeSumHelper.ThreeSum(targetArray));
        }
    }
}