/*
 * @lc app=leetcode.cn id=121 lang=csharp
 *
 * [121] 买卖股票的最佳时机
 */

// @lc code=start
public class Solution121 {
    public int MaxProfit(int[] prices) {
        //时间复杂度太高了
        // int max = 0;
        // for(int i = prices.Length - 1; i >= 0; i--)
        // {
        //     for(int j = 0; j < i; j++)
        //     {
        //         if(max < prices[i] - prices[j])
        //         {
        //             max = prices[i] - prices[j];
        //         }
        //     }
        // }
        // return max;

        //只要知道第i天前最小的价格是多少，就可以有用一次遍历
        int minPrice = prices[0];
        int maxProfit = 0;
        for(int i = 1; i < prices.Length; i++)
        {
            if(minPrice > prices[i]) minPrice = prices[i];
            if(maxProfit < prices[i] - minPrice) maxProfit = prices[i] - minPrice;
        }
        return maxProfit;
    }
}
// @lc code=end

