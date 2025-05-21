/*
 * @lc app=leetcode.cn id=2302 lang=csharp
 *
 * [2302] 统计得分小于 K 的子数组数目
 */

// @lc code=start
public class Solution2302
{
    public long CountSubarrays(int[] nums, long k)
    {
        long cnt = 0;
        long sum = 0;
        long score = 0;
        long length = nums.Length;
        long ans = 0;

        int left = 0;
        for (int right = 0; right < length; right++)
        {
            //in
            cnt++;
            sum += nums[right];
            score = cnt * sum;
            //out
            while (score >= k)
            {
                cnt--;
                sum -= nums[left];
                score = cnt * sum;
                left++;
            }
            //update
            ans += right - left + 1;
        }
        return ans;
    }
}
// @lc code=end

