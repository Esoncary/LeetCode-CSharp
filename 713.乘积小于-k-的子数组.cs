/*
 * @lc app=leetcode.cn id=713 lang=csharp
 *
 * [713] 乘积小于 K 的子数组
 */

// @lc code=start
public class Solution713
{
    public int NumSubarrayProductLessThanK(int[] nums, int k)
    {
        if (k <= 1)
            return 0;
        int ans = 0;
        int length = nums.Length;
        int left = 0;
        int mult = 1;
        for (int right = 0; right < length; right++)
        {
            //in
            mult *= nums[right];
            while (mult >= k)
            {
                //out
                mult /= nums[left];
                left++;
            }
            //update
            ans += right - left + 1;
        }
        return ans;
    }
}
// @lc code=end

