public class Solution {
    public int MaxProfit(int[] prices) {
        var min = int.MaxValue;
        var profit = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            if (min != int.MaxValue)
                profit = Math.Max(profit, prices[i] - min);
            
            min = Math.Min(min, prices[i]);
        }

        return profit;
    }
}
