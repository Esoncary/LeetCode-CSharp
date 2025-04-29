/*
 * @lc app=leetcode.cn id=1004 lang=csharp
 *
 * [1004] 最大连续1的个数 III
 */

// @lc code=start
public class Solution1004
{
    public int LongestOnes(int[] nums, int k)
    {
        int length = nums.Length;
        int left = 0;
        int count_0 = 0;
        int count_1 = 0;
        int ans = 0;
        for (int right = 0; right < length; right++)
        {
            //in
            int x = nums[right];
            if (x == 1)
                count_1++;
            else
                count_0++;
            //out
            while (count_0 > k)
            {
                int c = nums[left];
                if (c == 1)
                    count_1--;
                else
                    count_0--;
                left++;
            }
            //update
            ans = Math.Max(ans, count_0 + count_1);
        }
        return ans;
    }
}
// @lc code=end

