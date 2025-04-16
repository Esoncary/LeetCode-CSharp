/*
 * @lc app=leetcode.cn id=283 lang=csharp
 *
 * [283] 移动零
 */

// @lc code=start
public class Solution283
{
    public void MoveZeroes(int[] nums)
    {
        int i0 = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                int tmp = nums[i];
                nums[i] = nums[i0];
                nums[i0] = tmp;
                i0++;
            }
        }
    }
}
// @lc code=end

