/*
 * @lc app=leetcode.cn id=674 lang=csharp
 *
 * [674] 最长连续递增序列
 */

// @lc code=start
public class Solution674
{
    public int FindLengthOfLCIS(int[] nums)
    {
        int n = nums.Length;
        int count = 0;
        int max = int.MinValue;
        for (int i = 1; i < n; i++)
        {
            if (nums[i] > nums[i - 1])
                count++;
            else
            {
                max = max > count + 1 ? max : count + 1; count = 0;
            }

        }
        max = max > count + 1 ? max : count + 1;
        return max;
    }
}
// @lc code=end

