using System.Collections.Generic;
using System.Linq;

namespace TDD_Practice
{
    public class ThreeSumHelper
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            var uniqueResult = new Dictionary<string, List<int>>();

            int[] sortedNums = nums.OrderBy(i => i).ToArray();

            for (int index = 0; index < sortedNums.Length; index++)
                for (int x = index + 1; x < sortedNums.Length; x++)
                    for (int y = x + 1; y < sortedNums.Length; y++)
                    {
                        var key = $"{sortedNums[index]},{sortedNums[x]},{sortedNums[y]}";
                        if (!uniqueResult.ContainsKey(key) && sortedNums[index] + sortedNums[x] + sortedNums[y] == 0)
                        {
                            uniqueResult.TryAdd(key, new List<int>
                            {
                                sortedNums[index],
                                sortedNums[x],
                                sortedNums[y]
                            });
                        }
                    }

            foreach (List<int> value in uniqueResult.Values)
                result.Add(value);

            return result;
        }
    }
}