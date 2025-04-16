/*
 * @lc app=leetcode.cn id=495 lang=csharp
 *
 * [495] 提莫攻击
 */

// @lc code=start
public class Solution495
{
    public int FindPoisonedDuration(int[] timeSeries, int duration)
    {
        // int p;
        // int q = 0;//指向上一个连续的下标
        // bool s = false;//判断是不是连续
        // int ans = 0;
        // for (int i = 0; i < timeSeries.Length; i++)
        // {
        //     p = timeSeries[i] + duration;
        //     if (i + 1 < timeSeries.Length && p >= timeSeries[i + 1])
        //     {
        //         if (!s)
        //             q = i;
        //         s = true;
        //     }
        //     else
        //     {
        //         ans += timeSeries[i] + duration - timeSeries[s ? q : i];
        //         s = false;
        //     }
        // }
        // return ans;
        int ans = 0;
        int expired = 0;
        for (int i = 0; i < timeSeries.Length; i++)
        {
            if (timeSeries[i] >= expired)
                ans += duration;
            else
                ans += timeSeries[i] + duration - expired;
            expired = timeSeries[i] + duration;
        }
        return ans;
    }
}
// @lc code=end

