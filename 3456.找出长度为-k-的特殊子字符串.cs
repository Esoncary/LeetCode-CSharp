/*
 * @lc app=leetcode.cn id=3456 lang=csharp
 *
 * [3456] 找出长度为 K 的特殊子字符串
 */

// @lc code=start
public class Solution3456
{
    public bool HasSpecialSubstring(string s, int k)
    {
        char[] arr = s.ToCharArray();
        int cnt = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            cnt++;
            if (i == arr.Length - 1 || s[i] != s[i + 1])
            {
                if (cnt == k)
                    return true;
                cnt = 0;
            }
        }
        return false;
    }
}
// @lc code=end

