/*
 * @lc app=leetcode.cn id=2529 lang=csharp
 *
 * [2529] 正整数和负整数的最大计数
 */

// @lc code=start
public class Solution2529
{
    public int MaximumCount(int[] nums)
    {
        //暴力
        // int pos = 0;
        // int neg = 0;
        // foreach (var item in nums)
        // {
        //     if (item > 0)
        //         pos++;
        //     if (item < 0)
        //         neg++;
        // }
        // return Math.Max(pos, neg);

        //二分
        //找到>0的第一个数 下标为i
        //后面（n-i）的都是pos
        //找到>=0的第一个数 下标为j
        //如果i==j 说明没有0
        //如果i!=j 说明 j..i为0

        return Math.Max(nums.Length - lower_bound(nums, 1), lower_bound(nums, 0));

    }
    public int lower_bound(int[] nums, int target)
    {
        int l = -1;
        int r = nums.Length;
        while (l + 1 < r)
        {
            int mid = l + (r - l) / 2;
            if (target > nums[mid])
                l = mid;
            else
                r = mid;
        }
        return r;
    }
}
// @lc code=end

