/*
 * @lc app=leetcode.cn id=35 lang=csharp
 *
 * [35] 搜索插入位置
 */

// @lc code=start
public class Solution35 {
    public int SearchInsert(int[] nums, int target) {
        int i = 0;
        int j = nums.Length - 1;
        int mid;
        while( i <= j)
        {
            mid = (i + j) / 2;
            if(nums[mid] == target)
            {
                return mid;
            }
            else if(nums[mid] < target)
            {
                i = mid + 1;
            }
            else
            {
                j = mid - 1;
            }
        } 
        return i;
    }
}
// @lc code=end

