/*
 * @lc app=leetcode.cn id=414 lang=csharp
 *
 * [414] 第三大的数
 */

// @lc code=start
public class Solution414
{
    public int ThirdMax(int[] nums)
    {
        //暴力
        int i = nums.Length - 1;
        Array.Sort(nums);
        if (nums.Length < 3)
            return nums[nums.Length - 1];
        int target = nums.Length - 3;
        while (i != target)
        {
            if (i - 1 >= 0 && nums[i] == nums[i - 1])
            {
                if (--target < 0)
                    return nums[nums.Length - 1];
            }
            i--;
        }
        return nums[i];
    }
}
// @lc code=end

