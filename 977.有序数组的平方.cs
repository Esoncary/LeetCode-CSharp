/*
 * @lc app=leetcode.cn id=977 lang=csharp
 *
 * [977] 有序数组的平方
 */

// @lc code=start
public class Solution977
{
    public int[] SortedSquares(int[] nums)
    {
        int length = nums.Length;
        int left = 0;
        int right = length - 1;
        int[] ans = new int[length];
        for (int p = length - 1; p >= 0; p--)
        {
            int x = nums[left] * nums[left];
            int y = nums[right] * nums[right];
            if (x > y)
            {
                ans[p] = x;
                left++;
            }
            else
            {
                ans[p] = y;
                right--;
            }
        }
        return ans;
    }
}
// @lc code=end

