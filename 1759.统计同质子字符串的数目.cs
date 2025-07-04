/*
 * @lc app=leetcode.cn id=1759 lang=csharp
 *
 * [1759] 统计同质子字符串的数目
 */

// @lc code=start
public class Solution1759
{
    public int CountHomogenous(string s)
    {
        const long mod = 1000000007;
        int n = s.Length;
        int cnt = 0;
        char last = 'A';
        int ans = 0;
        for (int i = 0; i < n; i++)
        {
            if (last.Equals(s[i]))
            {
                cnt++;
            }
            else
            {
                last = s[i];
                cnt = 1;
            }
            ans = (int)((ans + cnt) % mod);

        }
        return ans;
    }
}
// @lc code=end

