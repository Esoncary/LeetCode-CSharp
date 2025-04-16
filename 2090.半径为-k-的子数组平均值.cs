/*
 * @lc app=leetcode.cn id=2090 lang=csharp
 *
 * [2090] 半径为 k 的子数组平均值
 */

// @lc code=start
using System.Reflection;

public class Solution2090
{
    public int[] GetAverages(int[] nums, int k)
    {
        int n = nums.Length;
        int[] avgs = new int[n];
        Array.Fill<int>(avgs, -1);
        long sum = 0;
        for (int i = 0; i < n; i++)
        {
            //入
            sum += nums[i];
            // if (i - k < 0 || i + k >= n)
            //     avgs[i] = -1;
            if (i < 2 * k)
                continue;
            //更新
            avgs[i - k] = (int)sum / (2 * k + 1);
            //出
            sum -= nums[i - 2 * k];
        }
        return avgs;
    }
}
// @lc code=end

