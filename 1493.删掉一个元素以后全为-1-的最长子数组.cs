/*
 * @lc app=leetcode.cn id=1493 lang=csharp
 *
 * [1493] 删掉一个元素以后全为 1 的最长子数组
 */

// @lc code=start
using System.Net.Http.Headers;

public class Solution1493
{
    public int LongestSubarray(int[] nums)
    {
        int length = nums.Length;
        int count_1 = 0;
        int count_0 = 0;
        int left = 0;
        int ans = 0;
        for (int right = 0; right < length; right++)
        {
            //in
            if (nums[right] == 0)
                count_0++;
            else
                count_1++;
            //out
            while (count_0 >= 2)
            {
                if (nums[left] == 0)
                {
                    count_0--;
                }
                else
                {
                    count_1--;
                }
                left++;
            }
            //update
            ans = Math.Max(ans, count_1);
        }
        return ans == length ? ans - 1 : ans;
    }
}
// @lc code=end

