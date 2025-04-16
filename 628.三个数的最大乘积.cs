/*
 * @lc app=leetcode.cn id=628 lang=csharp
 *
 * [628] 三个数的最大乘积
 */

// @lc code=start
public class Solution628
{
    public int MaximumProduct(int[] nums)
    {
        //排序法
        // Array.Sort(nums);
        // int n = nums.Length;
        // return Math.Max(nums[0] * nums[1] * nums[n - 1], nums[n - 3] * nums[n - 2] * nums[n - 1]);

        int min1 = int.MaxValue;
        int min2 = int.MaxValue;
        int max1 = int.MinValue;
        int max2 = int.MinValue;
        int max3 = int.MinValue;
        //非排序法
        foreach (int i in nums)
        {
            if (i < min1)
            {
                min2 = min1;
                min1 = i;
            }
            else if (i < min2)
            {
                min2 = i;
            }

            if (i > max1)
            {
                max3 = max2;
                max2 = max1;
                max1 = i;
            }
            else if (i > max2)
            {
                max3 = max2;
                max2 = i;
            }
            else if (i > max3)
            {
                max3 = i;
            }
        }
        return Math.Max(max1 * min1 * min2, max1 * max2 * max3);
    }
}
// @lc code=end

