/*
 * @lc app=leetcode.cn id=2389 lang=csharp
 *
 * [2389] 和有限的最长子序列
 */

// @lc code=start
public class Solution2389
{
    public int[] AnswerQueries(int[] nums, int[] queries)
    {
        int n = nums.Length;
        int m = queries.Length;
        Array.Sort(nums);
        //原地计算前缀和
        for (int i = 1; i < n; i++)
        {
            nums[i] += nums[i - 1];
        }
        //二分
        for (int i = 0; i < m; i++)
        {
            queries[i] = lower_bound(nums, queries[i] + 1);
        }
        return queries;
    }
    public int lower_bound(int[] nums, long target)
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

