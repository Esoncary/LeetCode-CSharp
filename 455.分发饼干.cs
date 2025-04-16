/*
 * @lc app=leetcode.cn id=455 lang=csharp
 *
 * [455] 分发饼干
 */

// @lc code=start
public class Solution455
{
    public int FindContentChildren(int[] g, int[] s)
    {
        if (s.Length == 0) return 0;
        int gIndex = 0;
        int sIndex = 0;
        Array.Sort(g);
        Array.Sort(s);
        int ans = 0;
        while (gIndex < g.Length && sIndex < s.Length)
        {
            if (s[sIndex] >= g[gIndex])
            {
                sIndex++;
                gIndex++;
                ans++;
            }
            else
            {
                sIndex++;
            }
        }
        return ans;
    }
}
// @lc code=end

