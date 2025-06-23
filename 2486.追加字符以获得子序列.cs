/*
 * @lc app=leetcode.cn id=2486 lang=csharp
 *
 * [2486] 追加字符以获得子序列
 */

// @lc code=start
public class Solution
{
    public int AppendCharacters(string s, string t)
    {
        int l = 0;
        int r = 0;
        int ans = 0;

        while (l < s.Length && r < t.Length)
        {
            if (s[l] == t[r])
                r++;
            l++;
        }
        if (l == s.Length && r < t.Length)
            //s走到最后 t没走到最后
            ans += t.Length - r;
        else
            //t走到最后了 s没走到最后
            ans = 0;

        return ans;
    }
}
// @lc code=end

