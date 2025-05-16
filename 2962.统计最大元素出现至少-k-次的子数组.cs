/*
 * @lc app=leetcode.cn id=2962 lang=csharp
 *
 * [2962] 统计最大元素出现至少 K 次的子数组
 */

// @lc code=start
public class Solution2962
{
    public long CountSubarrays(int[] nums, int k)
    {
        int max = int.MinValue;
        foreach (int item in nums)
        {
            max = Math.Max(item, max);
        }
        int length = nums.Length;
        int cnt = 0;
        int left = 0;
        long ans = 0;
        for (int right = 0; right < length; right++)
        {
            if (nums[right] == max)
                cnt++;
            while (cnt >= k)
            {
                ans += length - right;
                if (nums[left] == max)
                    cnt--;
                left++;
            }
        }
        return ans;
    }
}
// @lc code=end

