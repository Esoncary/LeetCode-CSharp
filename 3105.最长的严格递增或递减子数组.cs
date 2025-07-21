/*
 * @lc app=leetcode.cn id=3105 lang=csharp
 *
 * [3105] 最长的严格递增或递减子数组
 */

// @lc code=start
public class Solution3105
{
    public int LongestMonotonicSubarray(int[] nums)
    {
        int ans = 1;
        int i = 0, n = nums.Length;
        while (i < n - 1)
        {
            if (nums[i + 1] == nums[i])
            {
                i++; // 直接跳过
                continue;
            }
            int i0 = i; // 记录这一组的开始位置
            bool inc = nums[i + 1] > nums[i]; // 定下基调：是严格递增还是严格递减
            i += 2; // i 和 i+1 已经满足要求，从 i+2 开始判断
            while (i < n && nums[i] != nums[i - 1] && (nums[i] > nums[i - 1]) == inc)
            {
                i++;
            }
            // 从 i0 到 i-1 是满足题目要求的（并且无法再延长的）子数组
            ans = Math.Max(ans, i - i0);
            i--;
        }
        return ans;
    }
}
// @lc code=end

