/*
 * @lc app=leetcode.cn id=409 lang=csharp
 *
 * [409] 最长回文串
 */

// @lc code=start
using System.Text.RegularExpressions;

public class Solution409
{
    public int LongestPalindrome(string s)
    {

        // Dictionary<char, int> dic = new Dictionary<char, int>();
        // foreach (char i in s)
        // {
        //     if (!dic.ContainsKey(i))
        //     {
        //         dic.Add(i, 1);
        //     }
        //     else
        //     {
        //         dic[i]++;
        //     }
        // }
        // int count = 0;
        // foreach (int i in dic.Values)
        // {
        //     if (i % 2 == 0)
        //     {
        //         count += i;
        //     }
        //     else if (i > 2)
        //     {
        //         count += i - 1;
        //     }
        // }
        // if (count < s.Length)
        // {
        //     count++;
        // }
        // return count;

        int[] count = new int[128];
        for (int i = 0; i < s.Length; i++)
        {
            count[s[i]]++;
        }
        int ans = 0;
        foreach (int i in count)
        {
            ans += i / 2 * 2;
            if (i % 2 == 1 && ans % 2 == 0)
                ans++;
        }
        return ans;
    }
}
// @lc code=end

