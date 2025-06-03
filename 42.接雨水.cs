/*
 * @lc app=leetcode.cn id=42 lang=csharp
 *
 * [42] 接雨水
 */

// @lc code=start
public class Solution42
{
    public int Trap(int[] height)
    {
        int l = 0;
        int n = height.Length;
        int r = n - 1;
        int preMax = 0;
        int sufMax = 0;
        int ans = 0;
        while (l <= r)
        {
            preMax = Math.Max(preMax, height[l]);
            sufMax = Math.Max(sufMax, height[r]);
            ans += preMax < sufMax ? preMax - height[l++] : sufMax - height[r--];
        }
        return ans;
    }
}
// @lc code=end

