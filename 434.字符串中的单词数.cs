/*
 * @lc app=leetcode.cn id=434 lang=csharp
 *
 * [434] 字符串中的单词数
 */

// @lc code=start
public class Solution434
{
    public int CountSegments(string s)
    {
        int i = 0;
        int count = 0;
        while (i < s.Length)
        {
            // 如果当前字符不是空格，并且是字符串的第一个字符或者前一个字符是空格
            if (s[i] != ' ' && (i == 0 || s[i - 1] == ' '))
            {
                count++;
            }
            i++;
        }
        return count;
    }
}
// @lc code=end

