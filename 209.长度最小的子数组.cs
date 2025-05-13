/*
 * @lc app=leetcode.cn id=209 lang=csharp
 *
 * [209] 长度最小的子数组
 */

// @lc code=start
public class Solution209
{
    public int MinSubArrayLen(int target, int[] nums)
    {

        int left = 0;
        int length = nums.Length;
        int ans = int.MaxValue;
        int sum = 0;
        if (length == 0)
            return 0;
        for (int right = 0; right < length; right++)
        {
            //in
            sum += nums[right];
            //out
            while (sum >= target)
            {
                ans = Math.Min(ans, right - left + 1);
                sum -= nums[left];
                left++;
            }
        }
        return ans == int.MaxValue ? 0 : ans;
    }
}
// @lc code=end

