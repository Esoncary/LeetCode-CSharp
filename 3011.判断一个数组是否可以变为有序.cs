/*
 * @lc app=leetcode.cn id=3011 lang=csharp
 *
 * [3011] 判断一个数组是否可以变为有序
 */

// @lc code=start
using System.Numerics;

public class Solution3011
{
    public bool CanSortArray(int[] nums)
    {
        int n = nums.Length;
        int preMax = 0;
        for (int i = 0; i < n;)
        {
            int max = 0;
            int ones = Count(nums[i]);
            while (i < n && Count(nums[i]) == ones)
            {
                if (preMax > nums[i])
                    return false;
                max = Math.Max(max, nums[i]);
                i++;
            }
            preMax = max;
        }
        return true;
    }
    public int Count(int n)
    {
        uint x = (uint)n;
        return BitOperations.PopCount(x);
    }
}
// @lc code=end

