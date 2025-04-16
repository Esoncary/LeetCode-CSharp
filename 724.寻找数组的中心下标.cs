/*
 * @lc app=leetcode.cn id=724 lang=csharp
 *
 * [724] 寻找数组的中心下标
 */

// @lc code=start
public class Solution724
{
    public int PivotIndex(int[] nums)
    {
        //暴力
        // int left = 0;
        // int right = 0;
        // for (int i = 0; i < nums.Length; i++)
        // {
        //     for (int j = i - 1; j >= 0; j--)
        //     {
        //         left += nums[j];
        //     }
        //     for (int j = nums.Length - 1; j > i; j--)
        //     {
        //         right += nums[j];
        //     }
        //     if (right == left)
        //         return i;
        //     right = 0;
        //     left = 0;
        // }
        // return -1;

        //设nums的和为total，左侧的和为sum，则右侧为total - sum - nums[i]
        //则=找到中心点则 令 sum = total - sum - nums[i]
        //则 2 * sum = total - nums[i]
        int total = nums.Sum();
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (2 * sum == total - nums[i])
                return i;
            sum += nums[i];
        }
        return -1;
    }
}
// @lc code=end

