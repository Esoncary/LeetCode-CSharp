/*
 * @lc app=leetcode.cn id=2109 lang=csharp
 *
 * [2109] 向字符串添加空格
 */

// @lc code=start
using System.Text;

public class Solution2109
{
    public string AddSpaces(string s, int[] spaces)
    {
        //暴力
        // int n = spaces.Length + s.Length;
        // char[] ans = new char[n];
        // int l = 0;
        // int r = 0;
        // int j = 0;
        // while (l < s.Length)
        // {
        //     if (r < spaces.Length && l == spaces[r])
        //     {
        //         ans[j++] = ' ';
        //         r++;
        //     }
        //     else
        //     {
        //         ans[j] = s[l];
        //         j++;
        //         l++;
        //     }
        // }
        // return new string(ans);
        StringBuilder ans = new StringBuilder(s.Length + spaces.Length);
        int j = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (j < spaces.Length && spaces[j] == i)
            {
                ans.Append(' ');
                j++;
            }
            ans.Append(s[i]);
        }
        return ans.ToString();

    }
}
// @lc code=end

