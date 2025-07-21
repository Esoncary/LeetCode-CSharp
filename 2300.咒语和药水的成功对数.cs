/*
 * @lc app=leetcode.cn id=2300 lang=csharp
 *
 * [2300] 咒语和药水的成功对数
 */

// @lc code=start
using System.Runtime.CompilerServices;

public class Solution2300
{
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        //排序
        Array.Sort(potions);
        int[] ans = new int[spells.Length];
        int index = 0;
        foreach (var item in spells)
        {
            // int x = (int)Math.Ceiling((double)success / item);
            long x = ((success + item - 1) / item);
            ans[index] = potions.Length - lower_bound(potions, x);
            index++;
        }
        return ans;
    }
    public int lower_bound(int[] nums, long target)
    {
        int l = -1;
        int r = nums.Length;
        while (l + 1 < r)
        {
            int mid = l + (r - l) / 2;
            if (target > nums[mid])
                l = mid;
            else
                r = mid;
        }
        return r;
    }
}
// @lc code=end

