/*
 * @lc app=leetcode.cn id=795 lang=csharp
 *
 * [795] 区间子数组个数
 */

// @lc code=start
public class Solution795
{
    public int NumSubarrayBoundedMax(int[] nums, int left, int right)
    {
        // int n = nums.Length, ans = 0, i0 = -1, i1 = -1;
        // for (int i = 0; i < n; ++i)
        // {
        //     if (nums[i] > right) i0 = i;
        //     if (nums[i] >= left) i1 = i;
        //     ans += i1 - i0;
        // }
        // return ans;
        return calc(nums, right) - calc(nums, left - 1);

    }
    public int calc(int[] nums, int k)
    {
        int res = 0;
        for (int i = 0, j = 0; i < nums.Length; i++)
        {
            if (nums[i] > k)
                j = i + 1;
            res += i - j + 1;

        }
        return res;
    }
}
// @lc code=end

