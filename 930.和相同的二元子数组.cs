/*
 * @lc app=leetcode.cn id=930 lang=csharp
 *
 * [930] 和相同的二元子数组
 */

// @lc code=start
public class Solution930
{
    public int NumSubarraysWithSum(int[] nums, int goal)
    {
        int ans1 = 0;//>=
        int ans2 = 0;//>
        int left1 = 0;
        int left2 = 0;
        int length = nums.Length;
        int sum1 = 0;
        int sum2 = 0;
        for (int right = 0; right < length; right++)
        {
            //in
            sum1 += nums[right];
            sum2 += nums[right];
            while (sum1 >= goal && left1 <= right)
            {
                ans1 += length - right;
                sum1 -= nums[left1];
                left1++;
            }
            while (sum2 > goal && left2 <= right)
            {
                ans2 += length - right;
                sum2 -= nums[left2];
                left2++;
            }
        }
        return ans1 - ans2;
    }
}
// @lc code=end

