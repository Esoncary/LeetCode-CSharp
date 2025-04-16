/*
 * @lc app=leetcode.cn id=485 lang=csharp
 *
 * [485] 最大连续 1 的个数
 */

// @lc code=start
public class Solution485
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int max = 0;
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                count++;
                max = count > max ? count : max;
            }
            else
            {
                count = 0;
            }
        }
        return max;
    }
}
// @lc code=end

