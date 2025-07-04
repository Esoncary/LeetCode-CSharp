/*
 * @lc app=leetcode.cn id=1446 lang=csharp
 *
 * [1446] 连续字符
 */

// @lc code=start
public class Solution1446
{
    public int MaxPower(string s)
    {
        if (string.IsNullOrEmpty(s))
            return 0;
        int max = 1;
        int cnt = 1;
        for (int i = 1; i < s.Length; i++)
        {
            cnt = s[i] == s[i - 1] ? cnt + 1 : 1;
            if (cnt > max)
                max = cnt;
        }
        return max;
    }
}
// @lc code=end

