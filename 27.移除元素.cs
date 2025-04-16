/*
 * @lc app=leetcode.cn id=27 lang=csharp
 *
 * [27] 移除元素
 */

// @lc code=start
public class Solution27 {
    public int RemoveElement(int[] nums, int val) {
        int slow = 0;
        int fast = nums.Length - 1;
        if(nums.Length == 0) return 0;
        while( slow <= fast )
        {
            if( nums[slow] == val )
            {
                nums[slow] = nums[fast];
                nums[fast] = val;
                fast--;
            }
            else
            {
                slow++;
            }
        }
        return fast + 1;
    }
}
// @lc code=end

