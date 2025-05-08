/*
 * @lc app=leetcode.cn id=2730 lang=csharp
 *
 * [2730] 找到最长的半重复子字符串
 */

// @lc code=start
using System.Security.Cryptography.X509Certificates;

public class Solution2730
{
    public int LongestSemiRepetitiveSubstring(string s)
    {
        char[] arr = s.ToCharArray();
        int ans = 1;
        int same = 0;
        int left = 0;
        int length = arr.Length;
        for (int right = 1; right < length; right++)
        {
            if (arr[right] == arr[right - 1])
                same++;
            if (same > 1)
            {
                left++;
                while (arr[left] != arr[left - 1])
                {
                    left++;
                }
                same = 1;
            }
            ans = Math.Max(ans, right - left + 1);
        }
        return ans;
    }
}
// @lc code=end

