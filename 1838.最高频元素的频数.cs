/*
 * @lc app=leetcode.cn id=1838 lang=csharp
 *
 * [1838] 最高频元素的频数
 */

// @lc code=start
public class Solution1838
{
    public int MaxFrequency(int[] nums, int k)
    {
        Array.Sort(nums);
        int length = nums.Length;
        long sumCost = 0;
        int ans = 1;
        int left = 0;
        for (int right = 1; right < length; right++)
        {
            //right指的是目标值
            //in
            sumCost += (long)(nums[right] - nums[right - 1]) * (right - left);
            //out
            while (k < sumCost)
            {
                sumCost -= nums[right] - nums[left];
                left++;
            }
            //update
            ans = Math.Max(ans, right - left + 1);
        }
        return ans;
    }
}
// @lc code=end

