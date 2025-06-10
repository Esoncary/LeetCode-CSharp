/*
 * @lc app=leetcode.cn id=3467 lang=csharp
 *
 * [3467] 将数组按照奇偶性转化
 */

// @lc code=start
public class Solution3467
{
    public int[] TransformArray(int[] nums)
    {
        int n = nums.Length;
        int l = 0;
        int r = n - 1;

        while (l <= r)
        {
            if (nums[l] % 2 == 0)
            {
                nums[l] = 0;
                l++;
            }
            else if (nums[r] % 2 == 1)
            {
                nums[r] = 1;
                r--;
            }
            else
            {
                nums[r] = 1;
                nums[l] = 0;
                l++;
                r--;
            }
        }
        return nums;
    }
}
// @lc code=end

