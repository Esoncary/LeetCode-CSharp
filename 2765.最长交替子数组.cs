/*
 * @lc app=leetcode.cn id=2765 lang=csharp
 *
 * [2765] 最长交替子数组
 */

// @lc code=start
public class Solution2765
{
    public int AlternatingSubarray(int[] nums)
    {
        int ans = -1;
        int n = nums.Length;
        int i = 0;
        while (i < n - 1)
        {
            if (nums[i + 1] - nums[i] != 1)
            {
                i++;
                continue;
            }
            int start = i;
            i += 2;
            while (i < n && nums[i] == nums[i - 2])
            {
                i++;
            }
            ans = Math.Max(ans, i - start);
            i--;
        }
        return ans;
    }
}
// @lc code=end

