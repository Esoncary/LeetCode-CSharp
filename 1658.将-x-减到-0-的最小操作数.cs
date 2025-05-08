/*
 * @lc app=leetcode.cn id=1658 lang=csharp
 *
 * [1658] 将 x 减到 0 的最小操作数
 */

// @lc code=start
public class Solution1658
{
    public int MinOperations(int[] nums, int x)
    {
        //逆向思维：把问题变成找到最长的子数组，使nums-子数组后=x
        int sum = nums.Sum() - x;
        int left = 0;
        int count = 0;
        int length = nums.Length;
        int ans = -1;
        if (sum < 0)
        {
            return -1; // 全部移除也无法满足要求
        }
        for (int right = 0; right < length; right++)
        {
            //in
            sum -= nums[right];
            count++;
            //out
            while (sum < 0)
            {
                sum += nums[left];
                left++;
                count--;
            }
            //update
            if (sum == 0)
            {
                ans = Math.Max(ans, count);
            }
        }
        return ans < 0 ? -1 : length - ans;
    }
}
// @lc code=end

