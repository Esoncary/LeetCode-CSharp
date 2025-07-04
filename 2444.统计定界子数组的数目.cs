/*
 * @lc app=leetcode.cn id=2444 lang=csharp
 *
 * [2444] 统计定界子数组的数目
 */

// @lc code=start
public class Solution2444
{
    public long CountSubarrays(int[] nums, int minK, int maxK)
    {
        int lastInvalid = -1;
        int lastMax = -1;
        int lastMin = -1;
        long ans = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < minK || nums[i] > maxK)
                lastInvalid = i;
            if (nums[i] == minK)
                lastMin = i;
            if (nums[i] == maxK)
                lastMax = i;
            int validLeftCount = Math.Min(lastMax, lastMin) - lastInvalid;
            if (validLeftCount > 0)
                ans += validLeftCount;
        }
        return ans;
    }
}
// @lc code=end

