/*
 * @lc app=leetcode.cn id=35 lang=csharp
 *
 * [35] 搜索插入位置
 */

// @lc code=start
public class Solution35
{
    public int SearchInsert(int[] nums, int target)
    {
        return lower_bound3(nums, target);
    }
    public int lower_bound3(int[] nums, int target)
    {
        int l = -1;
        int r = nums.Length;
        while (l + 1 < r)
        {
            int mid = l + (r - l) / 2;
            if (nums[mid] >= target)
                r = mid;
            else
                l = mid;
        }
        return r;

    }
}
// @lc code=end

