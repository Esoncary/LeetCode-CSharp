/*
 * @lc app=leetcode.cn id=3350 lang=csharp
 *
 * [3350] 检测相邻递增子数组 II
 */

// @lc code=start
public class Solution3350
{
    public int MaxIncreasingSubarrays(IList<int> nums)
    {
        int ans = 0;
        int preCnt = 0;
        int cnt = 0;
        for (int i = 0; i < nums.Count; i++)
        {
            cnt++;
            // i 是严格递增段的末尾
            if (i == nums.Count - 1 || nums[i] >= nums[i + 1])
            {
                ans = Math.Max(ans, Math.Max(cnt / 2, Math.Min(preCnt, cnt)));
                preCnt = cnt;
                cnt = 0;
            }
        }
        return ans;

    }

}
// @lc code=end

