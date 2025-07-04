/*
 * @lc app=leetcode.cn id=1869 lang=csharp
 *
 * [1869] 哪种连续子字符串更长
 */

// @lc code=start
public class Solution1869
{
    public bool CheckZeroOnes(string s)
    {
        if (string.IsNullOrEmpty(s))
            return false;
        if (s.Length == 1)
            return s[0] == '1';
        int cnt_1 = 1;
        int cnt_0 = 1;
        int max_1 = 1;
        int max_0 = 1;
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1])
            {
                if (s[i] == '0')
                {
                    cnt_0++;
                }
                else
                {
                    cnt_1++;
                }
            }
            else
            {
                cnt_1 = 1;
                cnt_0 = 1;
            }
            max_0 = Math.Max(cnt_0, max_0);
            max_1 = Math.Max(cnt_1, max_1);
        }
        return max_1 > max_0;
    }

}
// @lc code=end

