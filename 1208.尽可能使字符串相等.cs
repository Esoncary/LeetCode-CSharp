/*
 * @lc app=leetcode.cn id=1208 lang=csharp
 *
 * [1208] 尽可能使字符串相等
 */

// @lc code=start
public class Solution1208
{
    public int EqualSubstring(string s, string t, int maxCost)
    {
        int length = s.Length;
        int left = 0;
        int ans = 0;
        int count = 0;
        int cost = 0;
        for (int right = 0; right < length; right++)
        {
            //in
            cost += Math.Abs(s[right] - t[right]);
            count++;
            //out
            while (cost > maxCost)
            {
                cost -= Math.Abs(s[left] - t[left]);
                count--;
                left++;
            }
            //update
            ans = Math.Max(ans, count);
        }
        return ans;
    }
}
// @lc code=end

