/*
 * @lc app=leetcode.cn id=704 lang=csharp
 *
 * [704] 二分查找
 */

// @lc code=start
public class Solution704
{
    public int Search(int[] nums, int target)
    {
        int l = -1;
        int r = nums.Length;
        while (l + 1 < r)
        {
            int mid = l + (r - l) / 2;
            if (nums[mid] < target)
                l = mid;
            else
                r = mid;
        }
        return r < nums.Length && nums[r] == target ? r : -1;
    }
}
// @lc code=end

