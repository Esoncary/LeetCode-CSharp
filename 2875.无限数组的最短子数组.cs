/*
 * @lc app=leetcode.cn id=2875 lang=csharp
 *
 * [2875] 无限数组的最短子数组
 */

// @lc code=start
public class Solution2875
{
    public int MinSizeSubarray(int[] nums, int target)
    {
        int ans = int.MaxValue;
        int left = 0;
        long sum = 0;
        int length = nums.Length;
        long total = 0;
        foreach (int item in nums)
        {
            total += item;
        }
        for (int right = 0; right < length * 2; right++)
        {
            //in
            sum += nums[right % length];
            //out
            while (sum > target % total)
            {
                sum -= nums[left % length];
                left++;
            }
            //update
            if (sum == target % total)
                ans = Math.Min(ans, right - left + 1);

        }
        return ans == int.MaxValue ? -1 : (int)(target / total) * length + ans;
    }
}
// @lc code=end

