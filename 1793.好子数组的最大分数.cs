/*
 * @lc app=leetcode.cn id=1793 lang=csharp
 *
 * [1793] 好子数组的最大分数
 */

// @lc code=start
using System.Globalization;

public class Solution1793
{
    public int MaximumScore(int[] nums, int k)
    {
        int n = nums.Length;
        int l = k;
        int r = k;
        int ans = nums[k];
        int minH = nums[k];

        for (int t = 0; t < n - 1; t++)
        {
            if (r == n - 1 || l > 0 && nums[l - 1] > nums[r + 1])
            {
                minH = Math.Min(minH, nums[--l]);
            }
            else
            {
                minH = Math.Min(minH, nums[++r]);
            }
            ans = Math.Max(ans, minH * (r - l + 1));
        }

        return ans;
    }
}
// @lc code=end

