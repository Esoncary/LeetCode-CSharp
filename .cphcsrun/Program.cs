/*
 * @lc app=leetcode.cn id=125 lang=csharp
 *
 * [125] 验证回文串
 */

// @lc code=start
using System.Text.RegularExpressions;

public class Solution125
{
    public bool IsPalindrome(string s)
    {
        //时间复杂度太高了
        // //移除所有非字母数字字符
        // s = Regex.Replace(s, @"[^a-zA-Z0-9]", "").ToLower();
        // //反转s
        // char[] array = s.ToCharArray();
        // Array.Reverse(array);
        // if(s.Equals(new String(array)))
        // {
        //     return true;
        // }
        // else
        // {
        //     return false;
        // }

        //双指针
        int i = 0; int j = s.Length - 1;
        while (i < j)
        {
            if ( !char.IsLetterOrDigit(s[i]))
            {
                i++;
            }
            else if ( !char.IsLetterOrDigit(s[j]))
            {
                j--;
            }
            else if (char.ToLower(s[i]) == char.ToLower(s[j]))
            {
                i++;
                j--;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}
// @lc code=end

