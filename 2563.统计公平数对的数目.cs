/*
 * @lc app=leetcode.cn id=2563 lang=csharp
 *
 * [2563] 统计公平数对的数目
 */

// @lc code=start
public class Solution2563
{
    public long CountFairPairs(int[] nums, int lower, int upper)
    {
        Array.Sort(nums);
        return count(nums, upper) - count(nums, lower - 1);

    }
    public long count(int[] nums, int k)
    {
        long l = 0;
        long length = nums.Length;
        long r = length - 1;
        long sum = 0;
        long ans = 0;
        while (l < r)
        {
            sum = nums[l] + nums[r];
            if (k < sum)
            {
                r--;
            }
            else
            {
                ans += r - l;
                l++;
            }
        }
        return ans;
    }
}
// @lc code=end

