using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Practice.Test
{
    internal class BestTimeToBuyAndSellStockIITest
    {
        [Test]
        public void TestMaxProfit()
        {
            //MaxProfitEqual(GenerateArray(7, 1, 5, 3, 6, 4), 7);
            MaxProfitEqual(GenerateArray(1, 2, 3, 4, 5), 4);
        }

        private static int[] GenerateArray(params int[] values)
        {
            return values;
        }

        private static void MaxProfitEqual(int[] nums, int expectedResult)
        {
            Assert.AreEqual(expectedResult, BestTimeToBuyAndSellStockIIHelper.MaxProfit(nums));
        }
    }
}
