/*
 * @lc app=leetcode.cn id=524 lang=csharp
 *
 * [524] 通过删除字母匹配到字典里最长单词
 */

// @lc code=start
public class Solution524
{
    public string FindLongestWord(string s, IList<string> dictionary)
    {
        int si = 0;
        int xi = 0;
        int n1 = s.Length;
        int n2 = dictionary.Count;
        string ans = "";
        foreach (var x in dictionary)
        {
            si = 0;
            xi = 0;

            while (si < n1 && xi < x.Length)
            {
                if (x[xi] == s[si])
                {
                    xi++;
                }
                si++;
            }
            if (xi == x.Length)
            {
                if (x.Length > ans.Length || ans.CompareTo(x) > 0 && x.Length == ans.Length)
                    ans = x;
            }
        }
        return ans;
    }
}
// @lc code=end

