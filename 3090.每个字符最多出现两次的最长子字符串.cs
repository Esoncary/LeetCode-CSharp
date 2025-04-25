/*
 * @lc app=leetcode.cn id=3090 lang=csharp
 *
 * [3090] 每个字符最多出现两次的最长子字符串
 */

// @lc code=start
public class Solution
{
    public int MaximumLengthSubstring(string s)
    {
        char[] chars = s.ToCharArray();
        int[] arr = new int[26];
        int length = s.Length;
        int ans = 0;
        int left = 0;
        for (int right = 0; right < length; right++)
        {
            //in
            char c = chars[right];
            arr[c - 'a']++;
            //out
            while (arr[c - 'a'] > 2)
            {
                arr[chars[left] - 'a']--;
                left++;
            }
            //updare
            ans = Math.Max(ans, right - left + 1);
        }
        return ans;
    }
}
// @lc code=end

