/*
 * @lc app=leetcode.cn id=561 lang=csharp
 *
 * [561] 数组拆分
 */

// @lc code=start
public class Solution561
{
    public int ArrayPairSum(int[] nums)
    {
        //要sum（min（a,b））加起来最小，就要让min（a，b）的损失最小，即两个最相近的组队
        int n = nums.Length;
        Array.Sort(nums);
        int ans = 0;
        for (int i = 0; i < n; i = i + 2)
        {
            ans += nums[i];
        }
        return ans;
    }
}
// @lc code=end

