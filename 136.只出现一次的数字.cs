/*
 * @lc app=leetcode.cn id=136 lang=csharp
 *
 * [136] 只出现一次的数字
 */

// @lc code=start
public class Solution136
{
    public int SingleNumber(int[] nums)
    {
        //时间复杂度太高了
        // if (nums.Length == 1) return nums[0];
        // Array.Sort(nums);
        // int i = 0;
        // while (nums[i] == nums[i + 1])
        // {
        //     if (i + 1 < nums.Length - 1 && i + 2 < nums.Length - 1)
        //     {
        //         i += 2;
        //     }
        //     else
        //     {
        //         return nums[nums.Length - 1];
        //     }

        // }
        // return nums[i];

        //异或  利用a ^ a = 0 的性质，找到只出现一次的元素。例如2 ^ 2 ^ 1 = 1。
        //0 ^ a = a
        int ans = 0;
        for(int i = 0; i< nums.Length; i++)
        {
            ans ^= nums[i];
        }
        return ans;
    }
}

// @lc code=end

