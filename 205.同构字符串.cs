/*
 * @lc app=leetcode.cn id=205 lang=csharp
 *
 * [205] 同构字符串
 */

// @lc code=start
public class Solution205
{
    public bool IsIsomorphic(string s, string t)
    {
        //哈希
        // Dictionary<char, char> dict = new Dictionary<char, char>();
        // for (int i = 0; i < s.Length; i++)
        // {
        //     if (dict.ContainsKey(s[i]))
        //     {
        //         if (dict[s[i]] != t[i])
        //         {
        //             return false;
        //         }
        //     }
        //     else
        //     {
        //         if (dict.ContainsValue(t[i]))
        //         {
        //             return false;
        //         }
        //         dict.Add(s[i], t[i]);
        //     }
        // }
        // return true;

        //paper 与 title
        // paper中各字母首次出现下标的序列为: [0, 1, 0, 3, 4]，
        // title中各字母首次出现下标的序列为: [0, 1, 0, 3, 4]
        // 因为下标数组一致，所以两字符串同构。
        List<int> sIndex = new List<int>();
        List<int> tIndex = new List<int>();
        for (int i = 0; i < s.Length; i++)
        {
            sIndex.Add(s.IndexOf(s[i]));
        }
        for (int i = 0; i < t.Length; i++)
        {
            tIndex.Add(t.IndexOf(t[i]));
        }
        return sIndex.SequenceEqual(tIndex);
    }
}
// @lc code=end

