namespace TDD_Practice
{
    public class BestTimeToBuyAndSellStockIIHelper
    {
        public static int MaxProfit(int[] prices)
        {
            int boughtIndex = -1;
            int profit = 0;

            for (int index = 0; index < prices.Length; index++)
            {
                if (boughtIndex == -1)
                {
                    boughtIndex = index;
                    continue;
                }

                if (prices[boughtIndex] > prices[index])
                {
                    boughtIndex = index;
                    continue;
                }

                if (index + 1 != prices.Length && prices[index] < prices[index + 1])
                {
                    continue;
                }
                else
                {
                    profit += prices[index] - prices[boughtIndex];
                    boughtIndex = -1;
                    continue;
                }
            }

            return profit;
        }
    }
}