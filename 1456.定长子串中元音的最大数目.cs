/*
 * @lc app=leetcode.cn id=1456 lang=csharp
 *
 * [1456] 定长子串中元音的最大数目
 */

// @lc code=start
public class Solution1456
{
    public int MaxVowels(string s, int k)
    {
        int count = 0;
        int ans = int.MinValue;
        for (int i = 0; i < s.Length; i++)
        {
            //入
            if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                count++;
            if (i < k - 1)
                continue;
            //更新
            ans = ans > count ? ans : count;
            //出
            char lev = s[i - k + 1];
            if (lev == 'a' || lev == 'e' || lev == 'i' || lev == 'o' || lev == 'u')
                count--;
        }
        return ans;
    }
}
// @lc code=end

