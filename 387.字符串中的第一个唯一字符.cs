/*
 * @lc app=leetcode.cn id=387 lang=csharp
 *
 * [387] 字符串中的第一个唯一字符
 */

// @lc code=start
using System.Reflection.PortableExecutable;

public class Solution387
{
    public int FirstUniqChar(string s)
    {
        // Dictionary<char, int> dic = new Dictionary<char, int>();
        // foreach (char i in s)
        // {
        //     if (dic.ContainsKey(i))
        //     {
        //         dic[i] += 1;
        //     }
        //     else
        //     {
        //         dic.Add(i, 1);
        //     }
        // }
        // for (int i = 0; i < s.Length; i++)
        // {
        //     if (dic[s[i]] == 1)
        //     {
        //         return i;
        //     }
        // }
        // return -1;

        int[] arr = new int[26];  //26个字母的数组
        for (int i = 0; i < s.Length; i++)
        {
            arr[s[i] - 'a'] += 1;  //a--0 b--1………… 对应位置数字+1
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (arr[s[i] - 'a'] == 1)  //当该位置数字为1
            {
                return i;
            }
        }
        return -1;
    }
}
// @lc code=end

