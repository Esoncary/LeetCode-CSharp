/*
 * @lc app=leetcode.cn id=290 lang=csharp
 *
 * [290] 单词规律
 */

// @lc code=start
public class Solution290
{
    public bool WordPattern(string pattern, string s)
    {
        Dictionary<char, string> dic = new Dictionary<char, string>();
        string[] arr = s.Split(" ");
        if (arr.Length != pattern.Length) return false;
        for (int i = 0; i < pattern.Length; i++)
        {
            if (!dic.ContainsKey(pattern[i]))
            {
                foreach (string a in dic.Values)
                {
                    if (a == arr[i])
                        return false;
                }
                dic.Add(pattern[i], arr[i]);
            }
            else if (dic[pattern[i]] != arr[i])
            {
                return false;

            }
        }
        return true;
    }
}
// @lc code=end

