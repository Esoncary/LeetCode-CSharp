/*
 * @lc app=leetcode.cn id=459 lang=csharp
 *
 * [459] 重复的子字符串
 */

// @lc code=start
public class Solution459
{
    public bool RepeatedSubstringPattern(string s)
    {
        int l = s.Length / 2;
        for (int i = 1; i <= l; i++)
        {
            if (s.Length % i != 0)
                continue;
            string patch = s.Substring(0, i);
            int beginIndex = i;
            while (beginIndex <= s.Length - i)
            {
                if (patch != s.Substring(beginIndex, i))
                    break;
                else if (beginIndex == s.Length - i)
                    return true;
                beginIndex += i;
            }
        }
        return false;
    }
}
// @lc code=end

