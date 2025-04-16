/*
 * @lc app=leetcode.cn id=242 lang=csharp
 *
 * [242] 有效的字母异位词
 */

// @lc code=start
public class Solution242
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }
        Dictionary<char, int> dic1 = new Dictionary<char, int>();
        Dictionary<char, int> dic2 = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (!dic1.ContainsKey(s[i]))
            {
                dic1.Add(s[i], 1);
            }
            else
            {
                dic1[s[i]]++;
            }

            if (!dic2.ContainsKey(t[i]))
            {
                dic2.Add(t[i], 1);
            }
            else
            {
                dic2[t[i]]++;
            }
        }
        foreach (char key in dic1.Keys)
        {
            if (!dic2.ContainsKey(key) || dic1[key] != dic2[key])
            {
                return false;
            }
        }
        return true;
    }
}
// @lc code=end

