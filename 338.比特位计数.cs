/*
 * @lc app=leetcode.cn id=338 lang=csharp
 *
 * [338] 比特位计数
 */

// @lc code=start
public class Solution338
{
    public int[] CountBits(int n)
    {
        // int[] arr = new int[n + 1];
        // for (int i = 0; i <= n; i++)
        // {
        //     arr[i] = Count1Num(i);
        // }
        // return arr;

        if (n == 0) return new int[] { 0 };
        int[] dp = new int[n + 1];
        dp[0] = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0) dp[i] = dp[i / 2];
            else dp[i] = dp[i - 1] + 1;
        }
        return dp;
    }
    // public int Count1Num(int n)
    // {
    //     int count = 0;
    //     while (n > 0)
    //     {
    //         n &= (n - 1);
    //         count++;
    //     }
    //     return count;
    // }
}
// @lc code=end

