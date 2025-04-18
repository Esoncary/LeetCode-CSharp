/*
 * @lc app=leetcode.cn id=2134 lang=csharp
 *
 * [2134] 最少交换次数来组合所有的 1 II
 */

// @lc code=start
public class Solution2134
{
    public int MinSwaps(int[] nums)
    {
        int k = 0;
        int sum = 0;
        int max = 0;
        int n = nums.Length;
        foreach (var item in nums)
        {
            if (item == 1)
                k++;
        }
        for (int i = 0; i < n + k - 1; i++)
        {
            //in
            if (nums[i % n] == 1)
                sum++;
            if (i < k - 1)
                continue;
            //update
            max = Math.Max(sum, max);
            //out
            if (nums[(i - k + 1) % n] == 1)
                sum--;
        }
        return k - max;
    }
}
// @lc code=end

