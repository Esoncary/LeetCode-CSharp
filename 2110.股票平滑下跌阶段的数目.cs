/*
 * @lc app=leetcode.cn id=2110 lang=csharp
 *
 * [2110] 股票平滑下跌阶段的数目
 */

// @lc code=start
public class Solution2110
{
    public long GetDescentPeriods(int[] prices)
    {
        int n = prices.Length;
        long ans = 0;
        int j = 0;
        int i = 1;
        for (; i < n; i++)
        {
            if (prices[i - 1] - prices[i] == 1)
                continue;
            ans += (long)(i - j) * (i - j + 1) / 2;
            j = i;
        }
        ans += (long)(i - j) * (i - j + 1) / 2;
        return ans;
    }
}
// @lc code=end

