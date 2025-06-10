/*
 * @lc app=leetcode.cn id=922 lang=csharp
 *
 * [922] 按奇偶排序数组 II
 */

// @lc code=start
public class Solution922
{
    public int[] SortArrayByParityII(int[] nums)
    {
        int l = 0;
        int r = 1;
        while (l < nums.Length)
        {
            if (nums[l] % 2 == 0)
                l += 2;
            else if (nums[r] % 2 == 1)
                r += 2;
            else
            {
                int temp = nums[l];
                nums[l] = nums[r];
                nums[r] = temp;
                l += 2;
                r += 2;
            }
        }


        return nums;
    }
}
// @lc code=end

