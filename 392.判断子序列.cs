/*
 * @lc app=leetcode.cn id=392 lang=csharp
 *
 * [392] 判断子序列
 */

// @lc code=start
public class Solution392
{
    public bool IsSubsequence(string s, string t)
    {
        int p = 0;
        int q = 0;
        while (p < s.Length && q < t.Length)
        {
            if (s[p] == t[q])
            {
                p++;
                q++;
            }
            else
            {
                q++;
            }

        }
        if (p == s.Length)
            return true;
        return false;
    }
}
// @lc code=end

