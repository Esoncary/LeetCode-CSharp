/*
 * @lc app=leetcode.cn id=26 lang=csharp
 *
 * [26] 删除有序数组中的重复项
 */

// @lc code=start
public class Solution26
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0)
            return 0;
        int slow = 0;
        int fast = 1;
        while (fast < nums.Length)
        {
            if (nums[slow] == nums[fast])
            {
                fast++;
            }
            else
            {
                slow++;
                nums[slow] = nums[fast];
            }
        }
        return slow + 1;
    }
}
// @lc code=end

