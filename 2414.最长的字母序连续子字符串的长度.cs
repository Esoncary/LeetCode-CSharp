/*
 * @lc app=leetcode.cn id=2414 lang=csharp
 *
 * [2414] 最长的字母序连续子字符串的长度
 */

// @lc code=start
public class Solution2414
{
    public int LongestContinuousSubstring(string s)
    {
        char[] S = s.ToArray();
        int cnt = 1;
        int ans = 1;
        for (int i = 1; i < S.Length; i++)
        {
            if (S[i - 1] + 1 == S[i])
                ans = Math.Max(ans, ++cnt);
            else
                cnt = 1;
        }
        return ans;
    }
}
// @lc code=end

