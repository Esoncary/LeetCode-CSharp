/*
 * @lc app=leetcode.cn id=2825 lang=csharp
 *
 * [2825] 循环增长使字符串子序列等于另一个字符串
 */

// @lc code=start
public class Solution2825
{
    public bool CanMakeSubsequence(string str1, string str2)
    {
        int l = 0;
        int r = 0;

        while (l < str1.Length && r < str2.Length)
        {
            if (str1[l] == str2[r] || (str1[l] - 'a' + 1) % 26 + 'a' == str2[r])
                r++;
            l++;
        }
        if (r == str2.Length)
            return true;
        return false;
    }
}
// @lc code=end

