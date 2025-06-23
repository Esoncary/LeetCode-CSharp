/*
 * @lc app=leetcode.cn id=844 lang=csharp
 *
 * [844] 比较含退格的字符串
 */

// @lc code=start
public class Solution844
{
    public bool BackspaceCompare(string s, string t)
    {
        string a = Process(s);
        string b = Process(t);
        return a.Equals(b);
    }
    public string Process(string s)
    {
        int n = s.Length;
        char[] sarr = new char[n];
        int j = 0;
        for (int i = 0; i < n; i++)
        {
            if (s[i] != '#')
            {
                sarr[j++] = s[i];
            }
            else if (j > 0)
            {
                j--;
            }
        }
        return new string(sarr, 0, j);
    }
}
// @lc code=end

