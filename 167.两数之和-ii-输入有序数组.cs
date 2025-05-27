/*
 * @lc app=leetcode.cn id=167 lang=csharp
 *
 * [167] 两数之和 II - 输入有序数组
 */

// @lc code=start
public class Solution167
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int n = numbers.Length;
        int l = 0;
        int r = n - 1;
        int sum = target - 1;
        while (sum != target)
        {
            sum = numbers[r] + numbers[l];
            if (sum > target)
            {
                r--;
            }
            else if (sum < target)
            {
                l++;
            }
        }
        return new int[] { l + 1, r + 1 };
    }
}
// @lc code=end

